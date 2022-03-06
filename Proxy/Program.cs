using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            YouTubeService youTubeService = new YouTubeService();
            youTubeService.GetVideo(10);
            youTubeService.GetVideo(10);

            ProxyYouTubeService proxyYouTubeService = new ProxyYouTubeService(youTubeService);
            proxyYouTubeService.GetVideo(10);
            proxyYouTubeService.GetVideo(10);

        }
    }
}
