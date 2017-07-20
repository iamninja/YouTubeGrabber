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

            // Get video info
            //var videoInfo = await client.GetVideoInfoAsync("opnjIcd4L8M");

            // Select the highest quality mixed stream
            // (can also use VideoStreams or AudioStreams, if needed)
            //var streamInfo = videoInfo.MixedStreams.OrderBy(s => s.VideoQuality).Last();

            // Download it to file
            //string fileExtension = streamInfo.Container.GetFileExtension();
            //string fileName = $"{videoInfo.Id}.{streamInfo.VideoQuality}.{fileExtension}";
            //await client.DownloadMediaStreamAsync(streamInfo, fileName);
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
    }
}
