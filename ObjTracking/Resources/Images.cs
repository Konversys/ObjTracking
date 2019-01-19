using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ObjTracking.R
{
    class Images
    {
        public static readonly BitmapImage Bear = new BitmapImage(new Uri(DefaultPath("Bear"), UriKind.Absolute));
        public static readonly BitmapImage Bird = new BitmapImage(new Uri(DefaultPath("Bird"), UriKind.Absolute));
        public static readonly BitmapImage Bull = new BitmapImage(new Uri(DefaultPath("Bull"), UriKind.Absolute));
        public static readonly BitmapImage Bulldog = new BitmapImage(new Uri(DefaultPath("Bulldog"), UriKind.Absolute));
        public static readonly BitmapImage Cat  = new BitmapImage(new Uri(DefaultPath("Cat"), UriKind.Absolute));
        public static readonly BitmapImage Chicken = new BitmapImage(new Uri(DefaultPath("Chicken"), UriKind.Absolute));
        public static readonly BitmapImage Duck = new BitmapImage(new Uri(DefaultPath("Duck"), UriKind.Absolute));
        public static readonly BitmapImage Owl = new BitmapImage(new Uri(DefaultPath("Owl"), UriKind.Absolute));
        public static readonly BitmapImage Wolf = new BitmapImage(new Uri(DefaultPath("Wolf"), UriKind.Absolute));
        public static readonly BitmapImage Forest = new BitmapImage(new Uri(DefaultPath("Forest"), UriKind.Absolute));

        static string DefaultPath(string name)
        {
            return $"D:/ASTU/7s/АПиПП/ObjTracking/ObjTracking/Resources/{name}.png";
        }
    }
}
