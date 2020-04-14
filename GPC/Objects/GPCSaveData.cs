using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GenPlan.Objects
{
    [Serializable()]
    public class GenPlanSaveData : ISerializable
    {
        public GenPlanSaveData(List<Group> groups, List<Room> rooms, List<Plan> plans)
        {
            Groups = groups;
            Rooms = rooms;
            Plans = plans;
        }

        public GenPlanSaveData(SerializationInfo info, StreamingContext context)
        {
            Groups = (List<Group>)info.GetValue("Groups", typeof(List<Group>));
            Rooms = (List<Room>)info.GetValue("Rooms", typeof(List<Room>));
            Plans = (List<Plan>)info.GetValue("Plans", typeof(List<Plan>));
        }

        public GenPlanSaveData()
        {
            Groups = new List<Group>();
            Rooms = new List<Room>();
            Plans = new List<Plan>();
        }

        public List<Group> Groups { get; set; }
        public List<Plan> Plans { get; set; }
        public List<Room> Rooms { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Groups", Groups);
            info.AddValue("Rooms", Rooms);
            info.AddValue("Plans", Plans);
        }
    }
}