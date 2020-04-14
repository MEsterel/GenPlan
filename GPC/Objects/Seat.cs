using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GenPlan.Objects
{
    [Serializable()]
    public class Seat : ISerializable
    {
        /// <summary>
        /// (Abscisse, Ordonnée)
        /// </summary>
        public (int, int) Coordonnees { get; set; }
        public string StudentName { get; set; } = "";
        public bool MustBeEmpty { get; set; } = false;
        public bool EmptyForGen { get; set; } = false;

        public Seat() { }

        public Seat(Seat seat)
        {
            Coordonnees = (seat.Coordonnees.Item1, seat.Coordonnees.Item2);
            StudentName = seat.StudentName;
            MustBeEmpty = seat.MustBeEmpty;
            EmptyForGen = seat.EmptyForGen;
        }

        public Seat((int, int) coordonnee)
        {
            Coordonnees = coordonnee;
        }

        public Seat((int, int) coordonnee, string studentName)
        {
            Coordonnees = coordonnee;
            StudentName = studentName;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Coordonnee", Coordonnees);
            info.AddValue("StudentName", StudentName);
            info.AddValue("MustBeEmpty", MustBeEmpty);
            info.AddValue("EmptyForGen", EmptyForGen);
        }

        public Seat(SerializationInfo info, StreamingContext context)
        {
            Coordonnees = ((int, int))info.GetValue("Coordonnee", typeof((int, int)));
            StudentName = info.GetString("Student");
            MustBeEmpty = info.GetBoolean("MustBeEmpty");
            EmptyForGen = info.GetBoolean("EmptyForGen");
        }
    }
}
