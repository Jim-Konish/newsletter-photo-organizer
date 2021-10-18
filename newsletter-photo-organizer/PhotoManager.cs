using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newsletter_photo_organizer
{
    public class PhotoManager
    {
        public List<String> allImages = new List<string>();
        public List<Photo> Photos = new List<Photo>();

        public string ImagesPath { get; set; }

        public int selectedImageIndex;

        public ClassList MyClassList;

        public PhotoManager(ClassList SelectedClassList)
        {
            // This just holds onto a reference to the external ClassList
            MyClassList = SelectedClassList;
            ImagesPath = "";
        }

        public void LoadImages(string path)
        {
            ImagesPath = path;

            try
            {
                var imagePathNames = Directory.EnumerateFiles(ImagesPath, "*.jp*g");

                foreach (string imagePathName in imagePathNames)
                {
                    allImages.Add(imagePathName);
                    Photos.Add(new Photo(MyClassList.Students, imagePathName));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            

        }

        public Photo GetSelectedImage()
        {
            return Photos[selectedImageIndex];
        }

        public void UpdateAllStudents()
        {
            // Zero each students count since we're rebuilding it from scratch
            foreach (Student student in MyClassList.Students)
            {
                student.Count = 0;
            }

            // Increment count for each student present in each starred photo
            foreach (Photo photo in Photos)
            {
                if (photo.Starred)
                {
                    foreach (Student student in MyClassList.Students)
                    {
                        if(photo.studentPresence[student])
                        {
                            student.Count++;
                        }
                    }
                }
            }
        }
    }
}
