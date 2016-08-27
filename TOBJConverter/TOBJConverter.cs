using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOBJConverter.IO;
using TOBJConverter.Types;

namespace TOBJConverter
{
	public partial class TOBJConverter : Form
	{
		private string GameDataDir = "";
	
		public TOBJConverter()
		{
			InitializeComponent();
		}

		private void ExitWithError(string message)
		{
			MessageBox.Show(
				message,
				"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			Application.Exit();
		}

		private void GoToTextboxEnd(TextBox t)
		{
			t.SelectionStart = t.TextLength;
			t.ScrollToCaret();
		}

		private string MakeRelativePath(string path, string basePath)
		{
			DirectoryInfo dirInfo = new DirectoryInfo(basePath);
			DirectoryInfo pathInfo = new DirectoryInfo(path);

			string fullBaseDir = dirInfo.FullName;
			string fullPathDir = pathInfo.FullName;

			if (!fullPathDir.StartsWith(fullBaseDir)) return null;

			return fullPathDir.Substring(fullBaseDir.Length + 1);
		}

		private void LoadTextureIntoPictureBox(string filename)
		{
			TexturePreviewBox.ImageLocation = filename;
			TexturePreviewBox.Load();
		}

		private void ConvertOBJToTOBJ(string filePath)
		{
			string fileName = Path.GetFileNameWithoutExtension(filePath);
		
			string objString = File.ReadAllText(filePath);

			ToriiObject tobj = new ToriiObject(objString, TextureFilePathField.Text);

			ToriiObjectWriter.Write(Path.Combine(OutputFilePathField.Text, fileName + ".tobj"), tobj);
		}

		private void OBJFilePathBrowseButton_Click(object sender, EventArgs e)
		{
			openFileDialog.FileName = "";
			openFileDialog.InitialDirectory = "";
			openFileDialog.Filter = "OBJ Files (*.obj)|*.obj";
			DialogResult r = DirectorySearchCheckbox.Checked ? folderBrowserDialog.ShowDialog() : openFileDialog.ShowDialog();

			if (r == DialogResult.OK)
			{
				string file = DirectorySearchCheckbox.Checked ? folderBrowserDialog.SelectedPath : openFileDialog.FileName;

				OBJFilePathField.Text = file;
				GoToTextboxEnd(OBJFilePathField);
			}
		}

		private void TextureFilePathBrowseButton_Click(object sender, EventArgs e)
		{
			openFileDialog.FileName = "";
			openFileDialog.Filter = "PNG Files (*.png)|*.png";
			openFileDialog.InitialDirectory = GameDataDir;

			DialogResult r = openFileDialog.ShowDialog();

			if (r == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				string relativePath = MakeRelativePath(fileName, GameDataDir);

				if (relativePath != null)
				{
					TextureFilePathField.Text = relativePath;
					GoToTextboxEnd(TextureFilePathField);

					LoadTextureIntoPictureBox(fileName);
				}
				else
					MessageBox.Show("Texture must be within game data directory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void TOBJConverter_Load(object sender, EventArgs e)
		{
			if (!File.Exists("gamedatadir.txt"))
			{
				ExitWithError("Could not load game data directory! Make sure you have a file in the same directory as this program called \"gamedatadir.txt\" containing the path to the game's data directory.");
				return;
			}
		
			GameDataDir = File.ReadAllText("gamedatadir.txt");
			GameDataDir = GameDataDir.Trim();

			try
			{
				Path.GetFullPath(GameDataDir);
			}
			catch (Exception ex)
			{
				ExitWithError("Loaded game data directory is not a valid path!");
				return;
			}

			if (!Directory.Exists(GameDataDir))
			{
				ExitWithError("Loaded game data directory does not exist!");
				return;
			}
		}

		private void OutputFilePathBrowseButton_Click(object sender, EventArgs e)
		{
			folderBrowserDialog.SelectedPath = GameDataDir;
			DialogResult r = folderBrowserDialog.ShowDialog();
			if (r == DialogResult.OK)
			{
				OutputFilePathField.Text = folderBrowserDialog.SelectedPath;
				GoToTextboxEnd(OutputFilePathField);
			}
		}

		private void ConvertButton_Click(object sender, EventArgs e)
		{
			if (OBJFilePathField.Text.Equals(string.Empty)
			    || TextureFilePathField.Text.Equals(string.Empty)
			    || OutputFilePathField.Text.Equals(string.Empty))
			{
				MessageBox.Show("Please make sure all text boxes have paths.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		
			if (DirectorySearchCheckbox.Checked)
			{
				// convert an entire directory
				string[] objFiles = Directory.GetFiles(OBJFilePathField.Text, "*.obj");

				Cursor.Current = Cursors.WaitCursor;

				foreach (string objFile in objFiles)
				{
					ConvertOBJToTOBJ(objFile);
				}
			}
			else
			{
				// convert a single file
				ConvertOBJToTOBJ(OBJFilePathField.Text);
			}

			Cursor.Current = Cursors.Default;

			MessageBox.Show("Successfully converted to TOBJ!", "Conversion success", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}
	}
}
