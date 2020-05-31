using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharp_advanced.Event
{
    public class VideoEventArgs: EventArgs
    {
        public Video video { get; set; }
    }
    public class VideoEncoder
    {
        //1. define a delegate
        //2. define an event based on that delegate
        //3. raise the event

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //public event VideoEncodedEventHandler VideoEncoded;

        //Event Handler
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnNewVideoEncoded(video);
        }

        private void OnNewVideoEncoded(Video video)
        {
           if(VideoEncoded!= null)
            {
                VideoEncoded(this, new VideoEventArgs() { video = video});
            }
        }
    }
}
