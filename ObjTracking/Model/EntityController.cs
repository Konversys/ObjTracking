using ObjTracking.Objects.Model;
using ObjTracking.Objects.Model.Entities;
using ObjTracking.R;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ObjTracking.Model
{
    class EntityController
    {
        List<Entity> entities;
        Canvas canvas;

        public EntityController(Canvas canvas)
        {
            this.canvas = canvas;
            entities = new List<Entity>();
            int h = (int)canvas.Height;
            int w = (int)canvas.Width;
            entities.Add(new Bird(w, h));
            entities.Add(new Wolf(w, h));
            entities.Add(new Bird(w, h));
            entities.Add(new Duck(w, h));
            entities.Add(new Duck(w, h));
            entities.Add(new Bird(w, h));
            entities.Add(new Bull(w, h));
            entities.Add(new Owl(w, h));
            entities.Add(new Bear(w, h));
            entities.Add(new Owl(w, h));
            entities.Add(new Duck(w, h));
            entities.Add(new Owl(w, h));
            entities.Add(new Cat(w, h));
            entities.Add(new Bulldog(w, h));
            entities.Add(new Bear(w, h));
            entities.Add(new Bird(w, h));
            entities.Add(new Chicken(w, h));
            entities.Add(new Bear(w, h));
            entities.Add(new Cat(w, h));
            entities.Add(new Bird(w, h));
        }

        public void UpdateEntities(ref Canvas canvas, int shift = 3)
        {
            canvas.Children.Clear();
            foreach (var item in entities)
            {
                item.ShiftVector(shift);
                canvas.Children.Add(item.GetCanvas());
            }
        }
    }
}
