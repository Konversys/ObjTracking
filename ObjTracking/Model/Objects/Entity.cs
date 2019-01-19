using ObjTracking.Model;
using ObjTracking.R;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ObjTracking.Objects.Model
{
    abstract class Entity
    {
        protected readonly static Random random = new Random();
        protected readonly int Width, Height;
        protected Entity(int width, int height, bool isMoveRight)
        {
            Width = width;
            Height = height;
            Point = new Point(random.Next(Width)-100, random.Next(Height-100));
            IsMoveRight = isMoveRight;
        }
        protected virtual PicSize Size => PicSize.Medium;

        public virtual int Movespeed => 5;
        public virtual bool IsMoveRight { get; protected set; }
        protected abstract BitmapImage Image { get; }
        public Point Point { get; protected set; }
        public void Offset(int dx, int dy)
        {
            Point = new Point(Point.X + dx, Point.Y + dy);
        }
        public Canvas GetCanvas()
        {
            Canvas can = new Canvas 
            {
                Background = new ImageBrush() { ImageSource = Image },
                Margin = new Thickness() { Left = Point.X, Top = Point.Y },
                Width = (uint)Size,
                Height = (uint)Size
            };
            return can;
        }
        public virtual void ShiftVector(int dx, bool isHorizontal = true, bool isChangePosition = true)
        {
            if (IsMoveRight)
            {
                if (Point.X + Movespeed + dx >= Width + (int)PicSize.VeryLarge + 1)
                {
                    IsMoveRight = !IsMoveRight;
                    if (isChangePosition)
                    {
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
                if (Point.X - Movespeed - dx <= -(Width + (int)PicSize.VeryLarge + 1))
                {
                    IsMoveRight = !IsMoveRight;
                    if (isChangePosition)
                    {
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

        public void ShiftRand(List<Entity> entities, int dx, int dy)
        {
            int x = random.Next(dx + 1) - dx / 2;
            int y = random.Next(dy + 1) - dy / 2;
            if (Point.X + x < 20)
            {
                x = Math.Abs(x);
            }
            if (Point.Y + y < 20)
            {
                y = Math.Abs(y);
            }
            if (Point.X + x >= Width - 200)
            {
                x = -Math.Abs(x);
            }
            if (Point.Y + y >= Height - 200)
            {
                y = -Math.Abs(y);
            }
            Offset(x, y);
        }
    }
}