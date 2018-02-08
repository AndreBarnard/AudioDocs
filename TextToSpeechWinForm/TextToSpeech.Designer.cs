﻿namespace TextToSpeech
{
	partial class TextToSpeech
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
			this.txtSpeech = new System.Windows.Forms.TextBox();
			this.btnSpeak = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.txtFileLocation = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnMakeMP3 = new System.Windows.Forms.Button();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtSpeech
			// 
			this.txtSpeech.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSpeech.Location = new System.Drawing.Point(12, 71);
			this.txtSpeech.Multiline = true;
			this.txtSpeech.Name = "txtSpeech";
			this.txtSpeech.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtSpeech.Size = new System.Drawing.Size(799, 435);
			this.txtSpeech.TabIndex = 0;
			// 
			// btnSpeak
			// 
			this.btnSpeak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSpeak.Location = new System.Drawing.Point(12, 537);
			this.btnSpeak.Name = "btnSpeak";
			this.btnSpeak.Size = new System.Drawing.Size(75, 23);
			this.btnSpeak.TabIndex = 1;
			this.btnSpeak.Text = "Speak";
			this.btnSpeak.UseVisualStyleBackColor = true;
			this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnClear.Location = new System.Drawing.Point(93, 537);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 2;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// txtFileLocation
			// 
			this.txtFileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFileLocation.Location = new System.Drawing.Point(13, 37);
			this.txtFileLocation.Name = "txtFileLocation";
			this.txtFileLocation.ReadOnly = true;
			this.txtFileLocation.Size = new System.Drawing.Size(709, 20);
			this.txtFileLocation.TabIndex = 3;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(728, 37);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(83, 20);
			this.btnBrowse.TabIndex = 4;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnMakeMP3
			// 
			this.btnMakeMP3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnMakeMP3.Location = new System.Drawing.Point(174, 537);
			this.btnMakeMP3.Name = "btnMakeMP3";
			this.btnMakeMP3.Size = new System.Drawing.Size(75, 23);
			this.btnMakeMP3.TabIndex = 5;
			this.btnMakeMP3.Text = "Make MP3";
			this.btnMakeMP3.UseVisualStyleBackColor = true;
			this.btnMakeMP3.Click += new System.EventHandler(this.btnMakeMP3_Click);
			// 
			// txtFileName
			// 
			this.txtFileName.Location = new System.Drawing.Point(12, 513);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(799, 20);
			this.txtFileName.TabIndex = 6;
			// 
			// TextToSpeech
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 568);
			this.Controls.Add(this.txtFileName);
			this.Controls.Add(this.btnMakeMP3);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtFileLocation);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnSpeak);
			this.Controls.Add(this.txtSpeech);
			this.Name = "TextToSpeech";
			this.Text = "TextToSpeech";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSpeech;
		private System.Windows.Forms.Button btnSpeak;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.TextBox txtFileLocation;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnMakeMP3;
		private System.Windows.Forms.TextBox txtFileName;
	}
}

