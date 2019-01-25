using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;

namespace BeamTracker
{
    interface IEntity
    {
        BitmapImage Image { get; }
        double Size { get; }
        Thickness Thickness { get; }
    }
}
