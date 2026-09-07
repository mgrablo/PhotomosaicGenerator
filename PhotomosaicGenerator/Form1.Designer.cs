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
            panel1 = new Panel();
            numericUpDown2 = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label4 = new Label();
            btnChooseFolder = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnChooseBigPicture = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnChooseFolder);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnChooseBigPicture);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 697);
            panel1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown2.Location = new Point(238, 458);
            numericUpDown2.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(58, 33);
            numericUpDown2.TabIndex = 16;
            numericUpDown2.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(23, 460);
            label6.MaximumSize = new Size(203, 60);
            label6.Name = "label6";
            label6.Size = new Size(167, 25);
            label6.TabIndex = 15;
            label6.Text = "Small pictures size";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(23, 569);
            label5.MaximumSize = new Size(203, 60);
            label5.Name = "label5";
            label5.Size = new Size(196, 25);
            label5.TabIndex = 14;
            label5.Text = "Small pictures opacity";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(238, 567);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(58, 33);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // checkBox2
            // 
            checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            checkBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.ForeColor = SystemColors.ControlLight;
            checkBox2.Location = new Point(23, 532);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(273, 29);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "High accuracy";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.ControlLight;
            checkBox1.Location = new Point(23, 497);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(273, 29);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Only pixelate";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(23, 624);
            button1.Name = "button1";
            button1.Size = new Size(273, 49);
            button1.TabIndex = 9;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(123, 435);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 8;
            label4.Text = "0 Files found";
            label4.Visible = false;
            // 
            // btnChooseFolder
            // 
            btnChooseFolder.Location = new Point(238, 409);
            btnChooseFolder.Name = "btnChooseFolder";
            btnChooseFolder.Size = new Size(58, 23);
            btnChooseFolder.TabIndex = 7;
            btnChooseFolder.Text = "Choose";
            btnChooseFolder.UseVisualStyleBackColor = true;
            btnChooseFolder.Click += btnChooseFolder_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 409);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(211, 23);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(23, 356);
            label3.MaximumSize = new Size(203, 60);
            label3.Name = "label3";
            label3.Size = new Size(160, 50);
            label3.TabIndex = 5;
            label3.Text = "Folder with small pictures";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSlateGray;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(27, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnChooseBigPicture
            // 
            btnChooseBigPicture.Location = new Point(238, 136);
            btnChooseBigPicture.Name = "btnChooseBigPicture";
            btnChooseBigPicture.Size = new Size(58, 23);
            btnChooseBigPicture.TabIndex = 3;
            btnChooseBigPicture.Text = "Choose";
            btnChooseBigPicture.UseVisualStyleBackColor = true;
            btnChooseBigPicture.Click += btnChooseBigPicture_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 136);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(23, 108);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 1;
            label2.Text = "Big picture";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 9);
            label1.MaximumSize = new Size(230, 90);
            label1.Name = "label1";
            label1.Size = new Size(192, 74);
            label1.TabIndex = 0;
            label1.Text = "Photomosaic Generator";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(327, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(986, 697);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1314, 697);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Photomosaic Generator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);

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
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private NumericUpDown numericUpDown1;
		private Label label5;
		private Label label6;
		private NumericUpDown numericUpDown2;
	}
}