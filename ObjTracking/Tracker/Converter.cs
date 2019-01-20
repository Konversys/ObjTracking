using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ObjTracking.Tracker
{
    class Converter
    {
        public static byte[] ConvertToByteArray(BitmapImage image, int count = 0)
        {
            byte[] sourceArray = new byte[262144];
            image.CopyPixels(sourceArray, 1024, 0);
            if (count <= 0)
            {
                return sourceArray.Where(x => x != 0).ToArray();
            }
            return sourceArray.Where(x => x != 0).Take(count).ToArray();
        }
    }
}
