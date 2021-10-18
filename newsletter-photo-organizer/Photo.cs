using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newsletter_photo_organizer
{
    public class Photo
    {
        public string PathName;
        public Dictionary<Student, bool> studentPresence { get; }
        public bool Starred { get; private set; }

        public Photo(List<Student> studentsParam, string pathName)
        {
            studentPresence = new Dictionary<Student, bool>();
            foreach (Student student in studentsParam)
            {
                studentPresence.Add(student, false);
            }

            PathName = pathName;
            Starred = false;
        }

        public void Star()
        {
            Starred = true;
        }

        public void UnStar()
        {
            Starred = false;
        }

        public void ToggleStarred()
        {
            Starred = !Starred;
        }
    }
}