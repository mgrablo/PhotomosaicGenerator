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
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnChooseFolder = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnChooseBigPicture = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label4);
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
			this.panel1.Size = new System.Drawing.Size(321, 618);
			this.panel1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(23, 557);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(180, 49);
			this.button1.TabIndex = 9;
			this.button1.Text = "Generate";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label4.Location = new System.Drawing.Point(70, 398);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "0 Files found";
			this.label4.Visible = false;
			// 
			// btnChooseFolder
			// 
			this.btnChooseFolder.Location = new System.Drawing.Point(174, 372);
			this.btnChooseFolder.Name = "btnChooseFolder";
			this.btnChooseFolder.Size = new System.Drawing.Size(33, 23);
			this.btnChooseFolder.TabIndex = 7;
			this.btnChooseFolder.Text = "button2";
			this.btnChooseFolder.UseVisualStyleBackColor = true;
			this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(27, 372);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(150, 23);
			this.textBox2.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(23, 319);
			this.label3.MaximumSize = new System.Drawing.Size(203, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 50);
			this.label3.TabIndex = 5;
			this.label3.Text = "Folder with small pictures";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(27, 165);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(178, 124);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
			this.textBox1.ReadOnly = true;
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
			this.openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(596, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(717, 572);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label5.Location = new System.Drawing.Point(30, 434);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = "Pixelate";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
			this.ClientSize = new System.Drawing.Size(1314, 618);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Photomosaic Generator";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
		private FolderBrowserDialog folderBrowserDialog1;
		private Label label4;
		private Button button1;
		private PictureBox pictureBox2;
		private Label label5;
	}
}