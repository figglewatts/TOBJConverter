namespace TOBJConverter
{
	partial class TOBJConverter
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.OBJFilePathField = new System.Windows.Forms.TextBox();
			this.OBJFileLabel = new System.Windows.Forms.Label();
			this.OBJFilePathBrowseButton = new System.Windows.Forms.Button();
			this.TextureFilePathLabel = new System.Windows.Forms.Label();
			this.TextureFilePathField = new System.Windows.Forms.TextBox();
			this.TextureFilePathBrowseButton = new System.Windows.Forms.Button();
			this.OutputFilePathLabel = new System.Windows.Forms.Label();
			this.OutputFilePathField = new System.Windows.Forms.TextBox();
			this.OutputFilePathBrowseButton = new System.Windows.Forms.Button();
			this.TexturePreviewBox = new System.Windows.Forms.PictureBox();
			this.ConvertButton = new System.Windows.Forms.Button();
			this.DirectorySearchCheckbox = new System.Windows.Forms.CheckBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			((System.ComponentModel.ISupportInitialize)(this.TexturePreviewBox)).BeginInit();
			this.SuspendLayout();
			// 
			// OBJFilePathField
			// 
			this.OBJFilePathField.Location = new System.Drawing.Point(15, 29);
			this.OBJFilePathField.Name = "OBJFilePathField";
			this.OBJFilePathField.Size = new System.Drawing.Size(345, 20);
			this.OBJFilePathField.TabIndex = 0;
			this.OBJFilePathField.WordWrap = false;
			// 
			// OBJFileLabel
			// 
			this.OBJFileLabel.AutoSize = true;
			this.OBJFileLabel.Location = new System.Drawing.Point(12, 13);
			this.OBJFileLabel.Name = "OBJFileLabel";
			this.OBJFileLabel.Size = new System.Drawing.Size(88, 13);
			this.OBJFileLabel.TabIndex = 1;
			this.OBJFileLabel.Text = "OBJ file/directory";
			// 
			// OBJFilePathBrowseButton
			// 
			this.OBJFilePathBrowseButton.Location = new System.Drawing.Point(366, 27);
			this.OBJFilePathBrowseButton.Name = "OBJFilePathBrowseButton";
			this.OBJFilePathBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.OBJFilePathBrowseButton.TabIndex = 2;
			this.OBJFilePathBrowseButton.Text = "Browse";
			this.OBJFilePathBrowseButton.UseVisualStyleBackColor = true;
			this.OBJFilePathBrowseButton.Click += new System.EventHandler(this.OBJFilePathBrowseButton_Click);
			// 
			// TextureFilePathLabel
			// 
			this.TextureFilePathLabel.AutoSize = true;
			this.TextureFilePathLabel.Location = new System.Drawing.Point(12, 52);
			this.TextureFilePathLabel.Name = "TextureFilePathLabel";
			this.TextureFilePathLabel.Size = new System.Drawing.Size(43, 13);
			this.TextureFilePathLabel.TabIndex = 3;
			this.TextureFilePathLabel.Text = "Texture";
			// 
			// TextureFilePathField
			// 
			this.TextureFilePathField.Location = new System.Drawing.Point(15, 68);
			this.TextureFilePathField.Name = "TextureFilePathField";
			this.TextureFilePathField.Size = new System.Drawing.Size(345, 20);
			this.TextureFilePathField.TabIndex = 4;
			this.TextureFilePathField.WordWrap = false;
			// 
			// TextureFilePathBrowseButton
			// 
			this.TextureFilePathBrowseButton.Location = new System.Drawing.Point(366, 66);
			this.TextureFilePathBrowseButton.Name = "TextureFilePathBrowseButton";
			this.TextureFilePathBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.TextureFilePathBrowseButton.TabIndex = 5;
			this.TextureFilePathBrowseButton.Text = "Browse";
			this.TextureFilePathBrowseButton.UseVisualStyleBackColor = true;
			this.TextureFilePathBrowseButton.Click += new System.EventHandler(this.TextureFilePathBrowseButton_Click);
			// 
			// OutputFilePathLabel
			// 
			this.OutputFilePathLabel.AutoSize = true;
			this.OutputFilePathLabel.Location = new System.Drawing.Point(12, 91);
			this.OutputFilePathLabel.Name = "OutputFilePathLabel";
			this.OutputFilePathLabel.Size = new System.Drawing.Size(82, 13);
			this.OutputFilePathLabel.TabIndex = 6;
			this.OutputFilePathLabel.Text = "Output directory";
			// 
			// OutputFilePathField
			// 
			this.OutputFilePathField.Location = new System.Drawing.Point(15, 108);
			this.OutputFilePathField.Name = "OutputFilePathField";
			this.OutputFilePathField.Size = new System.Drawing.Size(345, 20);
			this.OutputFilePathField.TabIndex = 7;
			this.OutputFilePathField.WordWrap = false;
			// 
			// OutputFilePathBrowseButton
			// 
			this.OutputFilePathBrowseButton.Location = new System.Drawing.Point(366, 106);
			this.OutputFilePathBrowseButton.Name = "OutputFilePathBrowseButton";
			this.OutputFilePathBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.OutputFilePathBrowseButton.TabIndex = 8;
			this.OutputFilePathBrowseButton.Text = "Browse";
			this.OutputFilePathBrowseButton.UseVisualStyleBackColor = true;
			this.OutputFilePathBrowseButton.Click += new System.EventHandler(this.OutputFilePathBrowseButton_Click);
			// 
			// TexturePreviewBox
			// 
			this.TexturePreviewBox.BackColor = System.Drawing.SystemColors.ControlDark;
			this.TexturePreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TexturePreviewBox.Location = new System.Drawing.Point(15, 135);
			this.TexturePreviewBox.Name = "TexturePreviewBox";
			this.TexturePreviewBox.Size = new System.Drawing.Size(200, 200);
			this.TexturePreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.TexturePreviewBox.TabIndex = 9;
			this.TexturePreviewBox.TabStop = false;
			// 
			// ConvertButton
			// 
			this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConvertButton.Location = new System.Drawing.Point(338, 299);
			this.ConvertButton.Name = "ConvertButton";
			this.ConvertButton.Size = new System.Drawing.Size(102, 35);
			this.ConvertButton.TabIndex = 10;
			this.ConvertButton.Text = "Convert";
			this.ConvertButton.UseVisualStyleBackColor = true;
			// 
			// DirectorySearchCheckbox
			// 
			this.DirectorySearchCheckbox.AutoSize = true;
			this.DirectorySearchCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.DirectorySearchCheckbox.Location = new System.Drawing.Point(334, 9);
			this.DirectorySearchCheckbox.Name = "DirectorySearchCheckbox";
			this.DirectorySearchCheckbox.Size = new System.Drawing.Size(106, 17);
			this.DirectorySearchCheckbox.TabIndex = 11;
			this.DirectorySearchCheckbox.Text = "Convert directory";
			this.DirectorySearchCheckbox.UseVisualStyleBackColor = true;
			// 
			// TOBJConverter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 347);
			this.Controls.Add(this.DirectorySearchCheckbox);
			this.Controls.Add(this.ConvertButton);
			this.Controls.Add(this.TexturePreviewBox);
			this.Controls.Add(this.OutputFilePathBrowseButton);
			this.Controls.Add(this.OutputFilePathField);
			this.Controls.Add(this.OutputFilePathLabel);
			this.Controls.Add(this.TextureFilePathBrowseButton);
			this.Controls.Add(this.TextureFilePathField);
			this.Controls.Add(this.TextureFilePathLabel);
			this.Controls.Add(this.OBJFilePathBrowseButton);
			this.Controls.Add(this.OBJFileLabel);
			this.Controls.Add(this.OBJFilePathField);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "TOBJConverter";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "TOBJ Converter";
			this.Load += new System.EventHandler(this.TOBJConverter_Load);
			((System.ComponentModel.ISupportInitialize)(this.TexturePreviewBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox OBJFilePathField;
		private System.Windows.Forms.Label OBJFileLabel;
		private System.Windows.Forms.Button OBJFilePathBrowseButton;
		private System.Windows.Forms.Label TextureFilePathLabel;
		private System.Windows.Forms.TextBox TextureFilePathField;
		private System.Windows.Forms.Button TextureFilePathBrowseButton;
		private System.Windows.Forms.Label OutputFilePathLabel;
		private System.Windows.Forms.TextBox OutputFilePathField;
		private System.Windows.Forms.Button OutputFilePathBrowseButton;
		private System.Windows.Forms.PictureBox TexturePreviewBox;
		private System.Windows.Forms.Button ConvertButton;
		private System.Windows.Forms.CheckBox DirectorySearchCheckbox;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
	}
}

