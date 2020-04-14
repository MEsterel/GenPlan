using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenPlan.Objects
{
    public class GenerationUserState
    {
        public Seat UpdatedSeat { get; set; }

        public (int, int) DebugSeat1 { get; set; } = (-1, -1);

        public (int, int) DebugSeat2 { get; set; } = (-1, -1);

        public float PlacedStudentsPercent { get; set; } = -1f;
    }
}
