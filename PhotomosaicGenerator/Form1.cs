using System.Runtime.InteropServices;

namespace PhotomosaicGenerator
{
	public partial class Form1 : Form
	{
		private string bigImageDir = "";
		private string folderDir = "";

		public Form1()
		{
			InitializeComponent();
			AllocConsole();
		}

		private void btnChooseBigPicture_Click(object sender, EventArgs e)
		{
			int size = -1;
			DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
			if (result == DialogResult.OK) // Test result.
			{
				string file = openFileDialog1.FileName;
				this.bigImageDir = file;
				try
				{
					string text = File.ReadAllText(file);
					this.textBox1.Text = file;
					this.pictureBox1.Load(file);
					size = text.Length;
				}
				catch (IOException)
				{
				}
			}
			Console.WriteLine(size); // <-- Shows file size in debugging mode.
			Console.WriteLine(result); // <-- For debugging use.
		}

		private void btnChooseFolder_Click(object sender, EventArgs e)
		{
			DialogResult result = folderBrowserDialog1.ShowDialog(); // Show the dialog.
			if (result == DialogResult.OK) // Test result.
			{
				string folder = folderBrowserDialog1.SelectedPath;
				this.textBox2.Text = folder;
				this.folderDir = folder;
				int fCount = Directory.GetFiles(folder).Length;
				this.label4.Text = fCount.ToString() + " Files found";
				this.label4.Visible = true;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			PhotomosaicGenerator gen = new PhotomosaicGenerator();
			gen.SetFolderDir(this.folderDir);
			gen.SetBigImageDir(this.bigImageDir);
			var imgURL = gen.Generate();
			Image img;
			using (var bmp = new Bitmap(imgURL))
			{
				img = new Bitmap(bmp);
			}
			this.pictureBox2.Image = img;
			Console.WriteLine(imgURL);
		}

		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool AllocConsole();
	}
}