using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ObjTracking.Model
{
    class Move
    {
        static Random rand;
        public static List<Entity> ShiftRand(List<Entity> entities, int dx, int dy)
        {
            if (rand == null)
            {
                rand = new Random();
            }
            foreach (var item in entities)
            {
                item.Offset(rand.Next(dx) - dx / 2, rand.Next(dy) - dy / 2);
            }
            return entities;
        }
    }
}
