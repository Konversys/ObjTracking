using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BeamTracker
{
    /// <summary>
    /// Фон
    /// </summary>
    public class Foundation
    {
        public Brush Brush { get; private set; }
        public double Opacity { get; private set; }
        public double Size { get; internal set; }
        public Foundation(Brush brush, double opacity = 1)
        {
            Brush = brush;
            Opacity = opacity;
        }
        public UIElement GetObject(double size)
        {
            Size = size;
            return new Canvas()
            {
                Background = Brush,
                Height = Size,
                Width = Size,
                Opacity = Opacity
            };
        }
    }
}
