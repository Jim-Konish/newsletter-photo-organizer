using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newsletter_photo_organizer
{
    public class Photo
    {
        public int refToPhoto;
        public Dictionary<String, bool> studentPresence { get; }
        public bool starred { get; private set; }

        public Photo(List<String> names, int refToPhotoArg)
        {
            foreach (String name in names)
            {
                studentPresence.Add(name, false);
            }

            refToPhoto = refToPhotoArg;
            starred = false;
        }

        public List<String> Star()
        {
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
    }
}