using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ObjTracking.Objects.Model
{
    abstract class FlyEntity : Entity
    {
        public FlyEntity(int width, int height, bool isMoveRight) : base(width, height, isMoveRight)
        {
            if (Point.Y > (1.5 * Height / 3))
            {
                Point = new Point(Point.X, random.Next(50, (int)(1.5 * Height / 3)));
            }
        }

        protected override abstract BitmapImage Image { get; }

        public override void ShiftVector(int dx, bool isHorizontal = true, bool isChangePosition = true)
        {
            dx = random.Next(0, dx);
            if (IsMoveRight)
            {
                if (Point.X + Movespeed + dx > Width)
                {
                    IsMoveRight = !IsMoveRight;
                    if (isChangePosition)
                    {
                        if (Point.Y > (1.5 * Height / 3))
                            Offset(0, -25);
                        else if (Point.Y < 0)
                            Offset(0, random.Next(25));
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
                        if (Point.Y < (1.5 * Height / 3))
                            Offset(0, -25);
                        else if (Point.Y < 0)
                            Offset(0, random.Next(25));
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
