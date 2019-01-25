using BeamTracker.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace BeamTracker
{
    interface IDetector
    {
        List<Entity> Search();
        List<Entity> GetImages();
    }
}
