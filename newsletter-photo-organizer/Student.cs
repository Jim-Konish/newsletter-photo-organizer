using System;
using System.Windows.Forms;

namespace newsletter_photo_organizer
{
    public class Student
    {
        public string Name { get; }
        public UInt16 Count { get; set;}
        public CheckBox MyCheckBox;

        public Student(string studentName)
        {
            Name = studentName;
            Count = 0;
        }
    }
}
