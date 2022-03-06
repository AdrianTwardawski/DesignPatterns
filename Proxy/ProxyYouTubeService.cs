using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyYouTubeService : IYouTubeService //zadaniem Proxy jest dodanie dodatkowej logiki,
                                                       //po to aby nasz program był wydajniejszy i zużywał mniej zasobów
    {
        private YouTubeService _youTubeService; //odnosimy się do prawdziwego serwisu
        private Dictionary<int, byte[]> _cache = new Dictionary<int, byte[]>(); //słownik, który będzie keszował nasze video

        public ProxyYouTubeService(YouTubeService youTubeService)
        {
            _youTubeService = youTubeService;
        }
        public byte[] GetVideo(int videoId)
        {
            Console.WriteLine($"ProxyYouTubeService getting {videoId}");

            byte[] cachedVideo;

            if(_cache.TryGetValue(videoId, out cachedVideo)) //sprawdzenie czy video nie jest juz zkeszowane, jeśli tak to możemy je zwrócić z cache'a
            {
                Console.WriteLine($"Getting from cache {videoId}");
                return cachedVideo;
            }

            var video = _youTubeService.GetVideo(videoId); //jeśli nie zostało zkeszowane to pobieramy video
            _cache.Add(videoId, video); //następnie dodajemy to wideo do słownika _cache

            return video;
            
        }
    }
}
