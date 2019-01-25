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
    /// Надпись
    /// </summary>
    public class Inscription
    {
        public string Title;
        public Brush Brush { get; private set; }
        public Thickness Margin { get; private set; }
        public double Opacity { get; private set; }
        public double FontSize { get; private set; }
        public HorizontalAlignment Horizontal { get; private set; }
        public VerticalAlignment Vertical { get; private set; }
        public Inscription(double fontSize, Brush brush, Thickness margin, double opacity = 1, HorizontalAlignment horizontal = HorizontalAlignment.Left, VerticalAlignment vertical = VerticalAlignment.Top)
        {
            FontSize = fontSize;
            Brush = brush;
            Margin = margin;
            Opacity = opacity;
            Vertical = vertical;
            Horizontal = horizontal;
        }
        public Inscription(Brush brush, Thickness margin, double opacity = 1, HorizontalAlignment horizontal = HorizontalAlignment.Left, VerticalAlignment vertical = VerticalAlignment.Top)
        {
            Brush = brush;
            Margin = margin;
            Opacity = opacity;
            Vertical = vertical;
            Horizontal = horizontal;
        }
        public UIElement GetObject()
        {
            TextBlock textBlock = new TextBlock()
            {
                Text = Title,
                Opacity = Opacity,
                Foreground = Brush,
                Margin = Margin,
                HorizontalAlignment = Horizontal,
                VerticalAlignment = Vertical,
            };
            if (FontSize != 0)
            {
                textBlock.FontSize = FontSize;
            }
            return textBlock;
        }
        public void SetTitle(string title)
        {
            Title = title;
        }
    }
}
