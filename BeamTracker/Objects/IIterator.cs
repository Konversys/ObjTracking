using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamTracker
{
    public interface IIterator
    {
        bool HasNext();
        Pattern Next();
        List<Pattern> GetPatterns();
    }
}
