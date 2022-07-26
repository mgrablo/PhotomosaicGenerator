using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace PhotomosaicGenerator
{
	internal class PhotomosaicGenerator
	{
		private string? FolderDir;
		private string? BigImageDir;

		private float smallImgOpacity = 1;
		private int squaresSize = 20;
		private bool pixelate = false;
		private bool extraAccuracy = false;

		public void SetBigImageDir(string directory)
		{
			this.BigImageDir = directory;
		}

		public void SetFolderDir(string directory)
		{
			this.FolderDir = directory;
		}

		public void SetSquaresSize(int size)
		{
			this.squaresSize = size;
		}

		public void SetSmallImgOpacity(float opacity)
		{
			this.smallImgOpacity = opacity;
		}

		public void SetPixelate(bool pixelate)
		{
			this.pixelate = pixelate;
		}

		public void SetExtraAccuracy(bool extraAccuracy)
		{
			this.extraAccuracy = extraAccuracy;
		}

		public string Generate()
		{
			using (Image<Rgba32> image = SixLabors.ImageSharp.Image.Load<Rgba32>(BigImageDir))
			{
				// Get list of big image squares
				List<Image<Rgba32>> squares = GetImageSquares(image, squaresSize);

				// Pixalate
				if (pixelate)
				{
					foreach (var square in squares)
					{
						// Get average color of each square
						var color = GetAverageImageColor(square);

						square.ProcessPixelRows(accessor =>
						{
							for (int y = 0; y < accessor.Height; y++)
							{
								Span<Rgba32> pixelRow = accessor.GetRowSpan(y);
								foreach (ref Rgba32 pixel in pixelRow)
								{
									pixel = color;
								}
							}
						});
					}
				}
				else
				{
					// Get list of small images
					var imgsDir = Directory.GetFiles(FolderDir);

					if (extraAccuracy)
					{
						Dictionary<Image<Rgba32>, List<Rgba32>> dicImgColors = new();
						//Resize images and add to List
						foreach (var imgString in imgsDir)
						{
							var img = SixLabors.ImageSharp.Image.Load<Rgba32>(imgString);
							ResizeOptions resizeOptions = new();
							resizeOptions.Mode = ResizeMode.Min;
							resizeOptions.Size = new(squaresSize, squaresSize);
							img.Mutate(x => x.Resize(resizeOptions));

							List<Image<Rgba32>> squaresSmallImg = GetImageSquares(img, squaresSize / 2);
							List<Rgba32> colors = new();
							foreach (var square in squaresSmallImg)
							{
								var color = GetAverageImageColor(square);
								colors.Add(color);
							}

							img.Mutate(x => x.DrawImage(PlaceSquaresOnImage(img, squaresSmallImg, squaresSize / 2), 1));
							dicImgColors.Add(img, colors);
						}

						foreach (var square in squares)
						{
							List<Image<Rgba32>> smallSquares = GetImageSquares(square, squaresSize / 2);
							List<Rgba32> smallSquaresColors = new();

							foreach (var smallSquare in smallSquares)
							{
								var smallSquareColor = GetAverageImageColor(smallSquare);
								smallSquaresColors.Add(smallSquareColor);
							}
							var bestMatch = FindBestMatchExtraAccuracy(smallSquaresColors, dicImgColors);
							square.Mutate(x => x.DrawImage(bestMatch, 1.0f));
						}
					}
					else
					{
						Dictionary<Image<Rgba32>, Rgba32> dicImgColor = new();

						//Resize images and add to dictionary with avg color
						foreach (var imgString in imgsDir)
						{
							var img = SixLabors.ImageSharp.Image.Load<Rgba32>(imgString);
							ResizeOptions resizeOptions = new();
							resizeOptions.Mode = ResizeMode.Min;
							resizeOptions.Size = new(squaresSize, squaresSize);
							img.Mutate(x => x.Resize(resizeOptions));

							dicImgColor.Add(img, GetAverageImageColor(img));
						}

						//Find best match for each square and replace square with small image
						foreach (var square in squares)
						{
							// Get average color of each square
							var color = GetAverageImageColor(square);

							var bestMatch = FindBestMatch(color, dicImgColor);
							square.Mutate(x => x.DrawImage(bestMatch, 1.0f));
						}
					}
				}

				image.Mutate(x => x.DrawImage(PlaceSquaresOnImage(image, squares, squaresSize), 1));
				image.Save(this.FolderDir + "\\photomosaic.jpg");
			}

			return this.FolderDir + "\\photomosaic.jpg";
		}

		// Extracts a sub-region of a sourceImage as a new image
		public Image<Rgba32> Extract(Image<Rgba32> sourceImage, SixLabors.ImageSharp.Rectangle sourceArea)
		{
			var targetImage = new Image<Rgba32>(sourceArea.Width, sourceArea.Height);
			sourceImage.ProcessPixelRows(targetImage, (sourceAccesor, targetAccessor) =>
			{
				for (int i = 0; i < sourceArea.Height; i++)
				{
					Span<Rgba32> sourceRow = sourceAccesor.GetRowSpan(sourceArea.Y + i);
					Span<Rgba32> targetRow = targetAccessor.GetRowSpan(i);

					sourceRow.Slice(sourceArea.X, sourceArea.Width).CopyTo(targetRow);
				}
			});

			return targetImage;
		}

		private Rgba32 GetAverageImageColor(Image<Rgba32> image)
		{
			float[] avgColor = { 0, 0, 0 };
			int n = 0;
			image.ProcessPixelRows(accessor =>
			{
				for (int y = 0; y < accessor.Height; y++)
				{
					Span<Rgba32> pixelRow = accessor.GetRowSpan(y);
					foreach (ref Rgba32 pixel in pixelRow)
					{
						avgColor[0] += pixel.R;
						avgColor[1] += pixel.G;
						avgColor[2] += pixel.B;
						n++;
					}
				}
			});

			avgColor[0] /= n;
			avgColor[1] /= n;
			avgColor[2] /= n;
			return new Rgba32((byte)avgColor[0], (byte)avgColor[1], (byte)avgColor[2]);
		}

		private double GetPythagorasDistance3d(Rgba32 rgb1, Rgba32 rgb2)
		{
			float distance = 0;

			distance = (rgb2.R - rgb1.R) * (rgb2.R - rgb1.R);
			distance += (rgb2.G - rgb1.G) * (rgb2.G - rgb1.G);
			distance += (rgb2.B - rgb1.B) * (rgb2.B - rgb1.B);

			return Math.Sqrt(distance);
		}

		private SixLabors.ImageSharp.Image? FindBestMatch(Rgba32 targetColor, Dictionary<Image<Rgba32>, Rgba32> dicImgColor)
		{
			SixLabors.ImageSharp.Image? bestMatch = null;
			double? bestMatchDistance = null;
			foreach (var item in dicImgColor)
			{
				double colorDistance = 0;
				for (int i = 0; i < 4; i++)
				{
					colorDistance += GetPythagorasDistance3d(targetColor, item.Value);
				}
				colorDistance /= 4;

				if (bestMatchDistance == null || colorDistance < bestMatchDistance)
				{
					bestMatch = item.Key;
					bestMatchDistance = colorDistance;
				}
			}

			return bestMatch;
		}

		private SixLabors.ImageSharp.Image? FindBestMatchExtraAccuracy(List<Rgba32> targetColors, Dictionary<Image<Rgba32>, List<Rgba32>> dicImgColors)
		{
			SixLabors.ImageSharp.Image? bestMatch = null;
			double? bestMatchDistance = null;

			foreach (var item in dicImgColors)
			{
				double colorDistance = 0;
				for (int i = 0; i < targetColors.Count; i++)
				{
					colorDistance += GetPythagorasDistance3d(targetColors[i], item.Value[i]);
				}

				if (bestMatchDistance == null || colorDistance < bestMatchDistance)
				{
					bestMatch = item.Key;
					bestMatchDistance = colorDistance;
				}
			}

			return bestMatch;
		}

		private List<Image<Rgba32>> GetImageSquares(Image<Rgba32> image, int squaresSize)
		{
			List<Image<Rgba32>> squares = new();
			int[] numOfSquares = { (int)Math.Ceiling((double)image.Height / squaresSize), (int)Math.Ceiling((double)image.Width / squaresSize) };
			for (int y = 0, imgRemainingHeight = image.Height; y < numOfSquares[0]; y++)
			{
				var imgRemainingWidth = image.Width;
				for (int x = 0; x < numOfSquares[1]; x++)
				{
					SixLabors.ImageSharp.Rectangle area = new();
					area.X = x * squaresSize;
					area.Y = y * squaresSize;
					if (imgRemainingWidth < squaresSize && imgRemainingWidth > 0)
					{
						area.Width = imgRemainingWidth;
					}
					else
					{
						area.Width = squaresSize;
					}

					if (imgRemainingHeight < squaresSize && imgRemainingHeight > 0)
					{
						area.Height = imgRemainingHeight;
					}
					else
					{
						area.Height = squaresSize;
					}

					if (imgRemainingWidth <= 0 || imgRemainingHeight <= 0)
					{
						continue;
					}
					squares.Add(Extract(image, area));
					imgRemainingWidth -= squaresSize;
				}
				imgRemainingHeight -= squaresSize;
			}
			return squares;
		}

		private Image<Rgba32> PlaceSquaresOnImage(Image<Rgba32> image, List<Image<Rgba32>> squares, int squaresSize)
		{
			for (int i = 0, rows = 0; i < squares.Count; i++)
			{
				var sqInRow = (int)Math.Ceiling((double)image.Width / squaresSize);
				if (i % sqInRow == 0)
				{
					rows++;
				}

				var smallImg = squares[i];
				var point = new SixLabors.ImageSharp.Point((i % sqInRow) * squaresSize, (rows - 1) * squaresSize);

				image.Mutate(x => x.DrawImage(smallImg, point, smallImgOpacity));
			}

			return image;
		}
	}
}