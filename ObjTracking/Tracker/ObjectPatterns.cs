using ObjTracking.R;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTracking.Tracker
{
    class ObjectPatterns
    {
        private static Dictionary<string, byte[]> dictionary = new Dictionary<string, byte[]>();
        public static Dictionary<string, byte[]> GetPatterns()
        {
            if (dictionary.Count == 0)
            {
                SetDefault();
            }
            return dictionary;
        }
        public static void ClearDictionary()
        {
            dictionary.Clear();
        }
        public static bool Add(string title, byte[] pattern)
        {
            try
            {
                dictionary.Add(title, pattern);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void SetDefault()
        {
            const int checkPixelCount = 100;
            dictionary.Add("Кот", Converter.ConvertToByteArray(Images.Cat, checkPixelCount));
            dictionary.Add("Птица", Converter.ConvertToByteArray(Images.Bird, checkPixelCount));
            dictionary.Add("Медведь", Converter.ConvertToByteArray(Images.Bear, checkPixelCount));
        }
        public static bool Remove(string title)
        {
            return dictionary.Remove(title);
        }
        public static bool Rename(string title, string newTitle)
        {
            if (dictionary.ContainsKey(title))
            {
                byte[] temp = dictionary[title];
                dictionary.Remove(title);
                dictionary.Add(newTitle, temp);
                return true;
            }
            return false;
        }
        public static byte[] GetPattern(string title)
        {
            if (dictionary.ContainsKey(title))
            {
                return dictionary[title];
            }
            return null;
        }
    }
}
