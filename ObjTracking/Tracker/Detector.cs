using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ObjTracking.Tracker
{
    class Detector
    {
        static List<BitmapImage> objects;
        static public void Detect(Canvas canvas, ref Canvas field)
        {
            field.Children.Clear();
            objects = new List<BitmapImage>();
            foreach (var item in canvas.Children.Cast<Canvas>())
            {
                objects.Add((BitmapImage)((ImageBrush)item.Background).ImageSource);
       //         string f = Comparator.TryDetect(objects.Last());
         //       if (f != null)
         //       {
         //           field.Children.Add(AddFrame((int)item.Margin.Left, (int)item.Margin.Top, f, (int)item.Height));
         //       }
            }
        }
        static Canvas AddFrame(int x, int y, string title, int size, int borderOpacity = 1, int borderThickness = 1)
        {
            return AddFrame(x, y, title, size, Brushes.Red, Brushes.Blue, borderOpacity, borderThickness);
        }
        static Canvas AddFrame(int x, int y, string title, int size, Brush bolderBrush, Brush textBrush, int opacity = 1, int borderThickness = 1)
        {
            Canvas canvas = new Canvas()
            {
                Margin = new Thickness
                {
                    Left = x,
                    Top = y
                },
                Height = size,
                Width = size
            };
            Canvas background = new Canvas()
            {
                Background = Brushes.Red,
                Opacity = 0.2,
                Height = size,
                Width = size
            };
            Border border = new Border()
            {
                BorderBrush = bolderBrush,
                Opacity = opacity,
                Height = size,
                Width = size,
                BorderThickness = new Thickness
                {
                    Bottom = borderThickness,
                    Left = borderThickness,
                    Right = borderThickness,
                    Top = borderThickness
                },
            };
            TextBlock textBlock = new TextBlock()
            {
                Text = title,
                Foreground = textBrush,
                Margin = new Thickness { Left = 5, Top = 3 }
            };
            canvas.Children.Add(border);
            canvas.Children.Add(textBlock);
            canvas.Children.Add(background);
            return canvas;
        }
    }
}
