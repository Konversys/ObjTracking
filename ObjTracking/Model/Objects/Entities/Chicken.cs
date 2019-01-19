using ObjTracking.Model;
using ObjTracking.R;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ObjTracking.Objects.Model.Entities
{
    class Chicken : GroundEntity
    {
        public Chicken(int width, int height, bool isMoveRight = true) : base(width, height, isMoveRight)
        {
        }

        protected override BitmapImage Image => Images.Chicken;

        protected override PicSize Size => PicSize.Small;
    }
}
