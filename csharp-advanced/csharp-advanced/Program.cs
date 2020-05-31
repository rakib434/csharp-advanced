using csharp_advanced.Delegate;
using csharp_advanced.Event;
using csharp_advanced.Extension_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {

            //-------------------------Delegate Start-----------------------------
            //var processor = new PhotoProcessors();
            //var filters = new PhotoFilters();
            //PhotoProcessors.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            //filterHandler += filters.ApplyContrast;

            var processor = new PhotoProcessorsAction();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            processor.Process("photo.jpg", filterHandler);

            //---------------------------Delegate End-----------------------------

            //---------------------------Lambda Start-----------------------------
            Func<int, int> result = square => square * square;
            Console.WriteLine(result(5));
            //---------------------------Lambda End-----------------------------

            //---------------------------Event Start-----------------------------
            Video video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
            //---------------------------Event End-----------------------------

            //---------------------------Extension Method Start-----------------------------
            string message = "I'm selfish, impatient and a little insecure. I make mistakes, I am out of control and at times hard to handle. But if you can't handle me at my worst, then you sure as hell don't deserve me at my best.";
            var shortMessage = message.Shorten(5);
            Console.WriteLine(shortMessage);
            //---------------------------Extension Method End-----------------------------
        }
    }
}
