using ObjTracking.R;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ObjTracking.Model
{
    abstract class Entity
    {
        protected Entity(uint width, uint height)
        {
            Random random = new Random();
            Point = new Point(random.Next((int)width)-1, random.Next((int)height-1));
        }

        protected abstract PicSize Size { get; }
        protected abstract BitmapImage Image { get; }
        protected Point Point { get; set; }
        public void Offset(int dx, int dy)
        {
            Point.Offset(dx, dy);
        }
        public Canvas GetCanvas()
        {
            Canvas can = new Canvas 
            {
                Background = new ImageBrush() { ImageSource = Image },
                Margin = new Thickness() { Left = Point.X, Top = Point.Y },
                Width = (uint)Size,
                Height = (uint)Size
            };
            return can;
        }
    }
}