using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

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
				// Get array of big image squares
				var rectangle = new SixLabors.ImageSharp.Rectangle(0, 0, squaresSize, squaresSize);
				var test = Extract(image, rectangle);
				var avg = GetAverageImageColor(test);
				Console.WriteLine(avg.R);

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
				for (int i = 0; i < height; i++)
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