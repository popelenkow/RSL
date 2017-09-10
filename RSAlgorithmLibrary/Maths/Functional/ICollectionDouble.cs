using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Maths.Functional
{
    public interface ICollectionDouble<T> : IEnumerable<double>
    {
        IEnumerable<T> Collection { get; set; }

    }
}
