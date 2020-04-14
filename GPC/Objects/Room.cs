using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace GenPlan.Objects
{
    [Serializable()]
    public class Room : ISerializable
    {
        public Room()
        {
        }

        public Room(string name)
        {
            Name = name;
        }

        public Room(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            _places = (List<(int, int)>)info.GetValue("Places", typeof(List<(int, int)>));
        }

        public string Name { get; set; } = "";

        public List<(int, int)> Places => _places;
        public int PlacesCount => _places.Count();
        private List<(int, int)> _places { get; set; } = new List<(int, int)>();

        public bool AddPlace(int Abscisse, int Ordonnee)
        {
            if (_places.Contains((Abscisse, Ordonnee)))
            {
                return false;
            }

            _places.Add((Abscisse, Ordonnee));
            return true;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Places", _places);
        }

        public bool RemovePlace(int Abscisse, int Ordonnee)
        {
            if (!_places.Contains((Abscisse, Ordonnee)))
            {
                return false;
            }

            _places.Remove((Abscisse, Ordonnee));
            return true;
        }

        public override string ToString()
        {
            return Name + " (" + PlacesCount + " places)";
        }
    }
}