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
        public Dictionary<String, bool> studentPresence { get; }
        public bool Starred { get; private set; }

        public Photo(List<String> names, string pathName)
        {
            studentPresence = new Dictionary<string, bool>();
            foreach (String name in names)
            {
                studentPresence.Add(name, false);
            }

            PathName = pathName;
            Starred = false;
        }

        public List<String> Star()
        {
            Starred = true;
            List<String> studentsPresent = new List<string>();
            foreach (String name in studentPresence.Keys)
            {
                if(studentPresence[name])
                {
                    studentsPresent.Add(name);
                }
            }

            return studentsPresent;
        }

        public List<String> UnStar()
        {
            Starred = false;
            List<String> studentsPresent = new List<string>();
            foreach (String name in studentPresence.Keys)
            {
                if (studentPresence[name])
                {
                    studentsPresent.Add(name);
                }
            }

            return studentsPresent;
        }

        public List<string> ToggleStarred()
        {
            if (Starred)
            {
                return UnStar();
            }
            else
            {
                return Star();
            }
        }
    }
}