using System.Windows;
using System.Windows.Media.Imaging;

namespace BeamTracker.Objects
{
    /// <summary>
    /// Параметры сущности выводимой на экран
    /// </summary>
    class Entity
    {
        public Entity(BitmapImage image, double size, Thickness thickness)
        {
            Image = image;
            Size = size;
            Thickness = thickness;
        }

        internal BitmapImage Image { get; private set; }
        internal double Size { get; private set; }
        internal Thickness Thickness { get; private set; }
}
}
