using System.Collections.Generic;

namespace newsletter_photo_organizer
{
    public class ClassList
    {
        public List<Student> students = new List<Student>();

        public ClassList(string[] names)
        {
            foreach (var name in names)
            {
                students.Add(new Student(name));
            }
        }
    }
}
