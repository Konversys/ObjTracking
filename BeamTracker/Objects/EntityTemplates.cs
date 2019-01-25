using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media.Imaging;

namespace BeamTracker
{
    /// <summary>
    /// Перечень известных шаблонов
    /// </summary>
    public class EntityTemplates : INumerable
    {
        private List<Pattern> patterns = new List<Pattern>();

        public int Count => patterns.Count;

        public Pattern this[int index] => patterns[index];

        public void Clear()
        {
            patterns.Clear();
        }
        public bool Add(string title, byte[] pattern)
        {
            try
            {
                if (patterns.All(x => x.Title != title))
                {
                    patterns.Add(new Pattern(title, pattern));
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add(string title, BitmapImage image)
        {
            try
            {
                if (patterns.All(x => x.Title != title))
                {
                    patterns.Add(new Pattern(title, Converter.ConvertToByteArray(image)));
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int Remove(string title)
        {
            return patterns.RemoveAll(x => x.Title == title);
        }
        public bool Rename(string title, string newTitle)
        {
            foreach (var item in patterns)
            {
                if (item.Title == title)
                {
                    byte[] temp = item.Template;
                    Remove(title);
                    Add(newTitle, temp);
                    return true;
                }
            }
            return false;
        }
        public IIterator CreateNumerator()
        {
            return new ObjectNumerator(this);
        }

        public List<Pattern> GetPatterns()
        {
            return patterns;
        }
    }
}
