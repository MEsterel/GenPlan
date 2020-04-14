using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GenPlan.Objects
{
    [Serializable()]
    public class PlanOptions
    {
        public bool IgnoreAffinities { get; set; }

        public AffinitiesModeEnum AffinitiesMode { get; set; }

        public bool AnimateGeneration { get; set; }

        public int AnimationSpeed { get; set; }

        public FillModeEnum FillMode { get; set; }

        public bool DebugMode { get; set; }
    }
}
