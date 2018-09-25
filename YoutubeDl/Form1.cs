using NYoutubeDL;
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

namespace YoutubeDl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string homePath = (Environment.OSVersion.Platform == PlatformID.Unix ||
                   Environment.OSVersion.Platform == PlatformID.MacOSX)
    ? Environment.GetEnvironmentVariable("HOME")
    : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            txtSaveFolder.Text = homePath;
        }

        private static string CleanFileName(string fileName)
        {
            return Path.GetInvalidFileNameChars().Aggregate(fileName, (current, c) => current.Replace(c.ToString(), string.Empty));
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            mainProgressBar.Visible = true;
            txtVideoUrl.Enabled = false;
            button1.Enabled = false;
            btnChange.Enabled = false;
            menuStrip1.Enabled = false;

            var youtubeDl = new YoutubeDL();

            // Optional, required if binary is not in $PATH
            youtubeDl.YoutubeDlPath = "lib/youtube-dl.exe";
            youtubeDl.VideoUrl = txtVideoUrl.Text;

            youtubeDl.Options.PostProcessingOptions.FfmpegLocation = "lib/ffmpeg.exe";
            youtubeDl.Options.PostProcessingOptions.PreferFfmpeg = true;

            var tmpFn = CleanFileName(DateTime.Now.ToString("ddMMyyyy hhmmss"));

            if (chkAudioOnly.Checked)
            {
                youtubeDl.Options.FilesystemOptions.Output = $"{txtSaveFolder.Text}/{tmpFn}.%(ext)s";
                youtubeDl.Options.PostProcessingOptions.AudioFormat = NYoutubeDL.Helpers.Enums.AudioFormat.mp3;
                youtubeDl.Options.PostProcessingOptions.KeepVideo = false;
                youtubeDl.Options.PostProcessingOptions.ExtractAudio = true;
            }
            else
            {
                youtubeDl.Options.FilesystemOptions.Output = $"{txtSaveFolder.Text}/{tmpFn}.mp4";
                youtubeDl.Options.VideoFormatOptions.Format = NYoutubeDL.Helpers.Enums.VideoFormat.mp4;
                youtubeDl.Options.PostProcessingOptions.KeepVideo = true;
            }

            string commandToRun = await youtubeDl.PrepareDownloadAsync();

            youtubeDl.StandardOutputEvent += (sdr, output) =>
            {
                Console.WriteLine(output);
                this.txtTerminal.Invoke((Action)delegate { this.txtTerminal.AppendText(Environment.NewLine + output); });
            };
            youtubeDl.StandardErrorEvent += (sdr, errorOutput) => Console.WriteLine(errorOutput);

            // Prepare the download (in case you need to validate the command before starting the download)
            //string commandToRun = await youtubeDl.PrepareDownloadAsync();


            youtubeDl.Info.PropertyChanged += delegate {
                this.mainProgressBar.Invoke((Action)delegate { this.mainProgressBar.Value = youtubeDl.Info.VideoProgress; });
                //mainProgressBar.Update();
                //var val = youtubeDl.Info.VideoProgress;
            };

            // Just let it run
            await youtubeDl.DownloadAsync();

            txtVideoUrl.Enabled = true;
            button1.Enabled = true;
            mainProgressBar.Visible = false;
            btnChange.Enabled = true;
            menuStrip1.Enabled = true;
        }

        private void quitYourJibberJabberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                txtSaveFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
