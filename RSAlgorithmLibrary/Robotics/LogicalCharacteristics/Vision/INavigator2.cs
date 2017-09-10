using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Robotics.LogicalCharacteristics
{
    public interface INavigator2
    {
        INavigationMap2 CreateMap();
    }
}
