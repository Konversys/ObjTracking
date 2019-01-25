using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamTracker.ObjectsPack
{
    /// <summary>
    /// Перечисление шаблонов
    /// </summary>
    public class ObjectNumerator : IIterator
    {
        INumerable objects;
        int index = 0;
        public ObjectNumerator(INumerable objects)
        {
            this.objects = objects;
        }

        public List<Pattern> GetPatterns()
        {
            return objects.GetPatterns();
        }

        public bool HasNext()
        {
            return index<objects.Count;
        }

        public Pattern Next()
        {
            return objects[index++];
        }
    }
}
