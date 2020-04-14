using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GenPlan.Objects
{
    [Serializable()]
    public class Plan : ISerializable
    {
        public string Name { get; set; } = "";

        public string RoomName { get; set; } = "";

        public string GroupName { get; set; } = "";

        public DateTime Date { get; set; } = DateTime.Now;

        public PlanOptions Options { get; set; } = new PlanOptions();

        public List<Seat> Seats { get; set; } = new List<Seat>();

        public int NotEmptySeatsCount => Seats.Count - EmptySeatsCount;

        public int EmptySeatsCount => Seats.FindAll(x => x.MustBeEmpty).Count;

        public Plan() { }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("RoomName", RoomName);
            info.AddValue("GroupName", GroupName);
            info.AddValue("Date", Date);
            info.AddValue("Options", Options);
            info.AddValue("Seats", Seats);
        }

        public Plan(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            RoomName = info.GetString("RoomName");
            GroupName = info.GetString("GroupName");
            Date = info.GetDateTime("Date");
            Options = (PlanOptions)info.GetValue("Options", typeof(PlanOptions));
            Seats = (List<Seat>)info.GetValue("Seats", typeof(List<Seat>));
        }
    }
}