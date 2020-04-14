using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GenPlan.Objects
{
    [Serializable()]
    public class Student : ISerializable
    {
        public Student() { }

        public Student(string name)
        {
            Name = name;
        }

        public Student(string name, List<string> talkingAffinities)
        {
            Name = name;
            TalkingAffinities = talkingAffinities;
        }

        public Student(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            TalkingAffinities = (List<string>)info.GetValue("TalkingAffinities", typeof(List<string>));
        }

        public Student(Student source)
        {
            Name = source.Name;
            TalkingAffinities = new List<string>(source.TalkingAffinities);
        }

        public string Name { get; set; } = "";

        public List<string> TalkingAffinities { get; private set; } = new List<string>();

        public void AddAffinity(Student student)
        {
            TalkingAffinities.Add(student.Name);

            // reciprocity of the affinity
            student._AddAffinity(this.Name);
        }

        public void DeleteAffinity(Student student)
        {
            TalkingAffinities.Remove(student.Name);

            // reciprocity of the affinity
            student._DeleteAffinity(this.Name);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("TalkingAffinities", TalkingAffinities);
        }

        public void RenameAffinity(Student student, string newName)
        {
            TalkingAffinities[TalkingAffinities.IndexOf(student.Name)] = newName;
            // no reciprocity, as the caller is supposed to rename itself at the end. Otherwise we would rename the caller n times.
        }

        public string[] TalkingAffinitiesToArray()
        {
            return TalkingAffinities.ToArray();
        }

        public string TalkingAffinitiesToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string af in TalkingAffinities)
            {
                sb.Append(af + ", ");
            }

            if (sb.Length != 0)
                sb.Length -= 2;

            return sb.ToString();
        }

        public override string ToString()
        {
            return Name;
        }

        private void _AddAffinity(string studentName)
        {
            TalkingAffinities.Add(studentName);
            TalkingAffinities.Sort();
        }

        private void _DeleteAffinity(string studentName)
        {
            TalkingAffinities.Remove(studentName);
        }
    }
}