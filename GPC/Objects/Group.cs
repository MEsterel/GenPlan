using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GenPlan.Objects
{
    [Serializable()]
    public class Group : ISerializable
    {
        public Group()
        {
        }

        public Group(string name) => Name = name;

        public Group(string name, List<Student> students)
        {
            Name = name;
            _students = students;
        }

        public Group(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            _students = (List<Student>)info.GetValue("Students", typeof(List<Student>));
        }

        public Group(Group source)
        {
            Name = source.Name;
            source.Students.ForEach(x => this.AddStudent(new Student(x)));
        }

        public string Name { get; set; } = "";

        public List<Student> Students => _students;
        public int StudentsCount => _students.Count;

        private List<Student> _students { get; set; } = new List<Student>();

        public void AddStudent(Student student) => _students.Add(student);

        public void ClearStudents() => _students.Clear();

        public void DeleteStudent(Student student)
        {
            foreach (string affinityName in student.TalkingAffinitiesToArray())
            {
                Student affinity = _students.Find(x => x.Name == affinityName);
                student.DeleteAffinity(affinity);
            }

            _students.Remove(student);
        }

        internal void AddRangeStudent(Student[] students)
        {
            _students.AddRange(students);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Students", _students);
        }

        internal void RenameStudent(Student student, string newName)
        {
            foreach (string affinityName in student.TalkingAffinitiesToArray())
            {
                Student affinity = _students.Find(x => x.Name == affinityName);
                affinity.RenameAffinity(student, newName);
            }

            student.Name = newName;
        }

        public override string ToString()
        {
            return Name + " (" + StudentsCount + " élèves)";
        }
    }
}