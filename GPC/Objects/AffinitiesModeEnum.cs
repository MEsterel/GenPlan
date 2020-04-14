using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GenPlan.Objects
{
    [Serializable()]
    public enum AffinitiesModeEnum
    {
        SideBySide = 0,
        OneSquareRadius = 1,
        TwoSquaresRadius = 2,
        ThreeSquaresRadius = 3,
        FourSquaresRadius = 4,
        FiveSquaresRadius = 5
    }
}
