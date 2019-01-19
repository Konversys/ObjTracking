using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ObjTracking.Objects.Model
{
    abstract class GroundEntity : Entity
    {
        public GroundEntity(int width, int height, bool isMoveRight) : base(width, height, isMoveRight)
        {
            if (Point.Y < 2 * Height / 3)
            {
                Point = new Point(Point.X, random.Next(2 * Height / 3, Height-50));
            }
        }

        protected override abstract BitmapImage Image { get; }

        public override void ShiftVector(int dx, bool isHorizontal = true, bool isChangePosition = true)
        {
            dx = random.Next(dx / 2, dx);
            if (IsMoveRight)
            {
                if (Point.X + Movespeed + dx > Width)
                {
                    IsMoveRight = !IsMoveRight;
                    if (isChangePosition)
                    {
                        if (Point.Y < 2 * Height / 3)
                            Offset(0, 25);
                        else if (Point.Y + (int)Size >= Height)
                            Offset(0, -(int)Size);
                        else
                            Offset(0, random.Next(-25, 25));
                    }
                }
                else
                {
                    if (isHorizontal)
                    {
                        Offset(Movespeed + random.Next(dx), 0);
                    }
                    else
                    {
                        Offset(0, Movespeed + random.Next(dx));
                    }
                }
            }
            else
            {
                if (Point.X - Movespeed - dx < -(int)Size)
                {
                    IsMoveRight = !IsMoveRight;
                    if (isChangePosition)
                    {
                        if (Point.Y < 2 * Height / 3)
                            Offset(0, 25);
                        else if (Point.Y + (int)Size > Height)
                            Offset(0, -(int)Size);
                        else
                            Offset(0, random.Next(-25, 25));
                    }
                }
                else
                {
                    if (isHorizontal)
                    {
                        Offset(-(Movespeed + random.Next(dx)), 0);
                    }
                    else
                    {
                        Offset(0, -(Movespeed + random.Next(dx)));
                    }
                }
            }
        }
    }
}
