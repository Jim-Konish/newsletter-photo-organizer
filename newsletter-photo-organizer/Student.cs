using System;

namespace newsletter_photo_organizer
{
    public class Student
    {
        public string Name { get; }
        public UInt16 count { get; set; }

        public Student(string studentName)
        {
            Name = studentName;
            count = 0;
        }
    }
}
