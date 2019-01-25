using BeamTracker.ObjectsPack;
using System.Windows.Media.Imaging;

namespace BeamTracker
{
    class Comparator
    {
        bool Compare(BitmapImage image, byte[] pattern)
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
        /// <summary>
        /// Сравнить изображение с предполагаемым шаблоном
        /// </summary>
        /// <param name="objects">Список шаблонов</param>
        /// <param name="image">Изображение</param>
        /// <returns></returns>
        public string TryDetect(EntityTemplates objects, BitmapImage image)
        {
            IIterator iterator = objects.CreateNumerator();
            foreach (var item in iterator.GetPatterns())
            {
                if (Compare(image, item.Template))
                {
                    return item.Title;
                }
            }
            return null;
        }
    }
}
