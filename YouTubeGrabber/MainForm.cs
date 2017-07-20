using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

using YoutubeExplode;
using YoutubeExplode.Models;

namespace YouTubeGrabber
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void downloadUrlButton_ClickAsync(object sender, EventArgs e)
        {
            YoutubeClient client = new YoutubeClient();

            // Get url from textBox
            string url = urlTextBox.Text;
            string videoId = getIdFromValidUrl(url);

            // Get video info
            progressBarInfo.Visible = true;
            progressBarInfo.Style = ProgressBarStyle.Marquee;
            var videoInfo = await client.GetVideoInfoAsync(videoId);
            progressBarInfo.Visible = false;
            progressBarInfo.Refresh();
            thumbnailBox.ImageLocation = videoInfo.ImageThumbnailUrl;
            nameLabel.Text = videoInfo.Title;
            durationLabel.Text = videoInfo.Duration.ToString();

            

            // Select the highest quality mixed stream
            // (can also use VideoStreams or AudioStreams, if needed)
            var streamInfo = videoInfo.MixedStreams.OrderBy(s => s.VideoQuality).Last();

            // Download it to file
            string fileExtension = streamInfo.Container.GetFileExtension();
            string fileName = $"{videoInfo.Id}.{streamInfo.VideoQuality}.{fileExtension}";
            await client.DownloadMediaStreamAsync(streamInfo, fileName);

            StartConverting($"{videoInfo.Id}.{streamInfo.VideoQuality}", $"{fileExtension}");
        }

        private void updateFormElements()
        {

        }

        private string getIdFromValidUrl(string url)
        {
            Uri uri = new Uri(url);

            var query = uri.Query.Length >= 1 ? uri.Query.Substring(1)
                .Split('&')
                .Select(part => part.Split('='))
                .Where(part => part.Length == 2)
                .ToDictionary(sp => sp[0], sp => sp[1]) : new Dictionary<string, string>();

            var videoId = String.Empty;

            if (query.ContainsKey("v"))
            {
                videoId = query["v"];
            }
            else
            {
                videoId = uri.Segments.Last();
            }

            //Console.WriteLine(videoId);
            return videoId;
        }

        public void StartConverting(string inputFileName, string fileExtention)
        {
            var inputFile = new MediaToolkit.Model.MediaFile { Filename = @".\" + inputFileName + "." + fileExtention };
            var outputFile = new MediaToolkit.Model.MediaFile { Filename = @".\" + inputFileName + ".mp3" };

            using (var engine = new MediaToolkit.Engine())
            {
                engine.ConvertProgressEvent += ConvertProgressEvent;
                engine.ConversionCompleteEvent += engine_ConversionCompleteEvent;
                engine.Convert(inputFile, outputFile);
            }
        }

        private void ConvertProgressEvent(object sender, MediaToolkit.ConvertProgressEventArgs e)
        {
            Console.WriteLine("\n------------\nConverting...\n------------");
            Console.WriteLine("Bitrate: {0}", e.Bitrate);
            Console.WriteLine("Fps: {0}", e.Fps);
            Console.WriteLine("Frame: {0}", e.Frame);
            Console.WriteLine("ProcessedDuration: {0}", e.ProcessedDuration);
            Console.WriteLine("SizeKb: {0}", e.SizeKb);
            Console.WriteLine("TotalDuration: {0}\n", e.TotalDuration);
        }

        private void engine_ConversionCompleteEvent(object sender, MediaToolkit.ConversionCompleteEventArgs e)
        {
            Console.WriteLine("\n------------\nConversion complete!\n------------");
            Console.WriteLine("Bitrate: {0}", e.Bitrate);
            Console.WriteLine("Fps: {0}", e.Fps);
            Console.WriteLine("Frame: {0}", e.Frame);
            Console.WriteLine("ProcessedDuration: {0}", e.ProcessedDuration);
            Console.WriteLine("SizeKb: {0}", e.SizeKb);
            Console.WriteLine("TotalDuration: {0}\n", e.TotalDuration);
        }
    }
}
