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
    class Bear : GroundEntity
    {
        public Bear(int width, int height, bool isMoveRight = true) : base(width, height, isMoveRight)
        {
        }

        protected override BitmapImage Image => Images.Bear;
        public override int Movespeed => 3;
        protected override PicSize Size => PicSize.Large;
    }
}
