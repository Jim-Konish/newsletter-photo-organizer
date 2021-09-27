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

        public List<string> StudentNames;

        public PhotoManager(List<string> studentNames)
        {
            StudentNames = studentNames;
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
                    Photos.Add(new Photo(StudentNames, imagePathName));
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
    }
}
