using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamTracker
{
    public interface INumerable
    {
        IIterator CreateNumerator();
        int Count { get; }
        bool Add(string title, byte[] pattern);
        int Remove(string title);
        bool Rename(string title, string newTitle);
        Pattern this[int index] { get; }
        List<Pattern> GetPatterns();
    }
}
