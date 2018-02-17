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

namespace TextToSpeech
{
	public partial class AudioDocs : Form
	{
		public AudioDocs()
		{
			InitializeComponent();
		}

		private void btnSpeak_Click(object sender, EventArgs e)
		{
			Text.TextToVoice TextToVoice = new Text.TextToVoice();
			TextToVoice.Rate = (int)numRate.Value;
			TextToVoice.ReadOutText = txtSpeech.Text;
			TextToVoice.Speak();

			TextToVoice = null;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtFileLocation.Text = "";
			txtSpeech.Text = "";
			txtFileName.Text = "";

		}
		private void btnBrowse_Click(object sender, EventArgs e)
		{
			Stream myStream = null;
			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			openFileDialog1.InitialDirectory = "c:\\";
			openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			openFileDialog1.FilterIndex = 2;

			openFileDialog1.RestoreDirectory = true;



			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					System.IO.FileInfo fInfo = new System.IO.FileInfo(openFileDialog1.FileName);
					string fullPath = $@"{fInfo.FullName}";

					txtFileName.Text = fInfo.Name.Replace(System.IO.Path.GetExtension(fullPath), "");
					txtFileLocation.Text = fullPath;

					Text.FileToString FileToString = new Text.FileToString(fullPath);

					txtSpeech.Text = FileToString.ReadText();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}
		}

		private void btnMakeMP3_Click(object sender, EventArgs e)
		{
			Text.TextToVoice TextToVoice = new Text.TextToVoice();
			TextToVoice.Rate = 1;
			TextToVoice.ReadOutText = txtSpeech.Text;
			string mp3path = $@"{System.IO.Directory.GetCurrentDirectory()}/{txtFileName.Text}.wav";
			if (TextToVoice.MakeMP3(mp3path))
			{
				MessageBox.Show($"MP3 File created successfully. Go to {mp3path}");
			}
			else
			{
				MessageBox.Show($"Failed to create MP3 file.");
			}

			TextToVoice = null;
		}

		private void AudioDocs_Load(object sender, EventArgs e)
		{

		}
	}
}
