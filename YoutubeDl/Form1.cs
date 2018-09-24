using NYoutubeDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var youtubeDl = new YoutubeDL();
            youtubeDl.Options.PostProcessingOptions.FfmpegLocation = "ffmpeg.exe";
            youtubeDl.Options.PostProcessingOptions.PreferFfmpeg = true;

            if (chkAudioOnly.Checked)
            {
                youtubeDl.Options.FilesystemOptions.Output = $"downloads/youtubedl.%(ext)s";
                youtubeDl.Options.PostProcessingOptions.AudioFormat = NYoutubeDL.Helpers.Enums.AudioFormat.mp3;
                youtubeDl.Options.PostProcessingOptions.KeepVideo = false;
                youtubeDl.Options.PostProcessingOptions.ExtractAudio = true;
            }
            else
            {
                youtubeDl.Options.FilesystemOptions.Output = $"downloads/youtubedl.mp4";
                youtubeDl.Options.VideoFormatOptions.Format = NYoutubeDL.Helpers.Enums.VideoFormat.mp4;
                youtubeDl.Options.PostProcessingOptions.KeepVideo = true;
            }
            
            youtubeDl.VideoUrl = txtVideoUrl.Text;
            // Optional, required if binary is not in $PATH
            youtubeDl.YoutubeDlPath = "youtube-dl.exe";

            // Prepare the download (in case you need to validate the command before starting the download)
            string commandToRun = await youtubeDl.PrepareDownloadAsync();

            // Just let it run
            txtVideoUrl.Enabled = false;
            button1.Enabled = false;
            button1.Text = "Downloading...";
            await youtubeDl.DownloadAsync();

            txtVideoUrl.Enabled = true;
            button1.Enabled = true;

            MessageBox.Show("Completed");
        }
    }
}
