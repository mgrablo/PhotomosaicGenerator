using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace PhotomosaicGenerator
{
	internal class PhotomosaicGenerator
	{
		private string? FolderDir;
		private string? BigImageDir;
		private int squaresSize = 20;

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

		public string Generate()
		{
			using (Image<Rgba32> image = SixLabors.ImageSharp.Image.Load<Rgba32>(BigImageDir))
			{
				// Get list of big image squares
				List<Image<Rgba32>> squares = new List<Image<Rgba32>>();
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

				//// Pixalate
				foreach (var square in squares)
				{
					Random rnd = new Random();
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
				//Place squares on big image
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
				// Get average color of each square

				// Get array of small images squares

				// Get average colors of small images squares

				image.Save(this.FolderDir + "\\photomosaic.jpg");
			}
			return this.FolderDir + "\\photomosaic.jpg";
		}

		// Extracts a sub-region of a sourceImage as a new image
		public Image<Rgba32> Extract(Image<Rgba32> sourceImage, SixLabors.ImageSharp.Rectangle sourceArea)
		{
			var targetImage = new Image<Rgba32>(sourceArea.Width, sourceArea.Height);
			var height = sourceArea.Height;
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
	}
}