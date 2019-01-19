using ObjTracking.R;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ObjTracking.Model.Entities
{
    class Wolf : Entity
    {
        public Wolf(uint width, uint height) : base(width, height)
        {
        }

        protected override BitmapImage Image => Images.Wolf;

        protected override PicSize Size => PicSize.Medium;
    }
}
