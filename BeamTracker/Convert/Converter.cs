using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace BeamTracker
{
    class Converter
    {
        /// <summary>
        /// Преобразовывает рисунок в массив байт
        /// </summary>
        /// <param name="image">Изображение</param>
        /// <param name="count">Количество считываемых байтов</param>
        /// <returns></returns>
        public static byte[] ConvertToByteArray(BitmapImage image, int count = 100)
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
