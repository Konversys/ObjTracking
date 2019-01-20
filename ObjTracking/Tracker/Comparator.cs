using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ObjTracking.Tracker
{
    class Comparator
    {
        public static bool Compare(BitmapImage image, byte[] pattern)
        {
            if (pattern != null)
            {
                byte[] array = Converter.ConvertToByteArray(image, pattern.Length);
                for (int i = 0; i < pattern.Length; i++)
                {
                    if (array[i] != pattern[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public static string TryDetect(BitmapImage image)
        {
            foreach (var item in ObjectPatterns.GetPatterns())
            {
                if (Compare(image, item.Value))
                {
                    return item.Key;
                }
            }
            return null;
        }
    }
}
