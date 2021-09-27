using System.Collections.Generic;

namespace newsletter_photo_organizer
{
    public class ClassList
    {
        private List<Student> students = new List<Student>();

        public ClassList(List<string> names)
        {
            foreach (var name in names)
            {
                Students.Add(new Student(name));
            }
        }

        public List<Student> Students { get => students; set => students = value; }
    }
}
