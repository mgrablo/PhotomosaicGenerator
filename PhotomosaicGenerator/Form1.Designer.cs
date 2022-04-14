namespace PhotomosaicGenerator
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnChooseFolder = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnChooseBigPicture = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.panel1.Controls.Add(this.btnChooseFolder);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.btnChooseBigPicture);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(230, 577);
			this.panel1.TabIndex = 0;
			// 
			// btnChooseFolder
			// 
			this.btnChooseFolder.Location = new System.Drawing.Point(174, 372);
			this.btnChooseFolder.Name = "btnChooseFolder";
			this.btnChooseFolder.Size = new System.Drawing.Size(33, 23);
			this.btnChooseFolder.TabIndex = 7;
			this.btnChooseFolder.Text = "button2";
			this.btnChooseFolder.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(27, 372);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(150, 23);
			this.textBox2.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(27, 319);
			this.label3.MaximumSize = new System.Drawing.Size(203, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 50);
			this.label3.TabIndex = 5;
			this.label3.Text = "Folder with small pictures";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(27, 165);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(178, 124);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// btnChooseBigPicture
			// 
			this.btnChooseBigPicture.Location = new System.Drawing.Point(174, 136);
			this.btnChooseBigPicture.Name = "btnChooseBigPicture";
			this.btnChooseBigPicture.Size = new System.Drawing.Size(33, 23);
			this.btnChooseBigPicture.TabIndex = 3;
			this.btnChooseBigPicture.Text = "button1";
			this.btnChooseBigPicture.UseVisualStyleBackColor = true;
			this.btnChooseBigPicture.Click += new System.EventHandler(this.btnChooseBigPicture_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(27, 136);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(150, 23);
			this.textBox1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(23, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Big picture";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(23, 9);
			this.label1.MaximumSize = new System.Drawing.Size(230, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 74);
			this.label1.TabIndex = 0;
			this.label1.Text = "Photomosaic Generator";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.FileName = "openFileDialog2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
			this.ClientSize = new System.Drawing.Size(951, 577);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Photomosaic Generator";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Button btnChooseBigPicture;
		private TextBox textBox1;
		private Label label2;
		private Label label3;
		private PictureBox pictureBox1;
		private Button btnChooseFolder;
		private TextBox textBox2;
		private OpenFileDialog openFileDialog1;
		private OpenFileDialog openFileDialog2;
	}
}