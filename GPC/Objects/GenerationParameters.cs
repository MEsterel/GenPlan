using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenPlan.Objects
{
    public class GenerationParameters
    {
        public Room Room { get; set; }
        public Group Group { get; set; }
        public PlanOptions PlanOptions { get; set; }
    }
}
