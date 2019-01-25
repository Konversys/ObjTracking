using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BeamTracker.FrameBase
{
    /// <summary>
    /// Обрамление
    /// </summary>
    public class Edge
    {
        public Brush Brush { get; private set; }
        public Thickness Thickness { get; private set; }
        public double Opacity { get; private set; }
        public double Size { get; internal set; }
        public Edge(Brush brush, Thickness thickness, double opacity = 1)
        {
            Brush = brush;
            Thickness = thickness;
            Opacity = opacity;
        }
        public UIElement GetObject(double size)
        {
            Size = size;
            return new Border()
            {
                BorderBrush = Brush,
                Opacity = Opacity,
                Height = Size,
                Width = Size,
                BorderThickness = Thickness,
            };
        }
    }
}
