using csharp_advanced.Delegate;
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

        }
    }
}
