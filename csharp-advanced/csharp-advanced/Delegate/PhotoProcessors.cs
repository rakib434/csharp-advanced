using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_advanced.Delegate
{
    public class PhotoProcessors
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            photo.Save();
        }
    }

    //Action Func
    public class PhotoProcessorsAction
    {
        public void Process(string path,Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            photo.Save();
        }
    }
}
