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
			BigImageDir = directory;
		}

		public void SetFolderDir(string directory)
		{
			FolderDir = directory;
		}

		public void SetSquaresSize(int size)
		{
			squaresSize = size;
		}

		public string Generate()
		{
			using Image<Rgba32> image = SixLabors.ImageSharp.Image.Load<Rgba32>(BigImageDir);


			image.Save(this.FolderDir + "\\photomosaic.jpg");
			image.Dispose();
			return this.FolderDir + "\\photomosaic.jpg";
		}
	}
}