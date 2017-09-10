using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSL.Robotics.LogicalCharacteristics
{
    public sealed class Navigator2Default : INavigator2
    {
        public INavigationMap2 CreateMap()
        {
            return new NavigationMap2();
        }
    }
}
