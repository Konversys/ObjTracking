using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BeamTracker
{
    /// <summary>
    /// Параметры сущности выводимой на экран
    /// </summary>
    class Entity : IEntity
    {
        public Entity(Canvas canvas)
        {
            Image = (BitmapImage)((ImageBrush)canvas.Background).ImageSource;
            Size = canvas.Height;
            Thickness = canvas.Margin;
        }
        public Entity(BitmapImage image, double size, Thickness thickness)
        {
            Image = image;
            Size = size;
            Thickness = thickness;
        }
        public BitmapImage Image { get; private set; }
        public double Size { get; private set; }
        public Thickness Thickness { get; private set; }
}
}
