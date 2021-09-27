using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newsletter_photo_organizer
{

    public partial class Form1 : Form
    {

        private string[] mwfNames =
        {
            "Aria",
            "Beric",
            "Catelyn",
            "Davos",
        };

        private string[] tthNames =
        {
            "Bilbo",
            "Frodo",
            "Gandalf",
            "Gimli"
        };

        private ClassList classList;

        public PhotoManager photoManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbxSourceFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSetupTabNext_Click(object sender, EventArgs e)
        {
            int xOffset = 10;
            int yOffset = 20;
            tabControl1.SelectedIndex += 1;

            int shortcutKey = 0;
            foreach (var student in classList.Students)
            {
                // Add student to list on next tab
                CheckBox box = new CheckBox();
                box.Text = "(" + shortcutKey.ToString() + ") " + student.Name;
                groupBoxStudentList.Controls.Add(box);
                box.Top = yOffset;
                box.Left = xOffset;
                yOffset += 20;
                shortcutKey++;
            }


            photoManager.LoadImages(tbxSourceFolder.Text);
            
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(tabControl1.SelectedTab == tabPageSelection)
            {
                tabPageSelection_KeyDown(sender, e);
            }
        }

        private void tabPageSelection_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyValue >= (int)Keys.D0) && (e.KeyValue <= (int)Keys.D9))
            {
                //TODO Look up the corresponding checkbox in the dictionary to be created.
            }
            if (e.KeyValue == (int)Keys.Left)
            {
                if(photoManager.selectedImageIndex <= 0)
                {
                    photoManager.selectedImageIndex = photoManager.allImages.Count - 1;
                }
                else
                {
                    photoManager.selectedImageIndex--;
                }
                updatePictureBoxImage();
            }
            if (e.KeyValue == (int)Keys.Right)
            {
                if (photoManager.selectedImageIndex >= photoManager.allImages.Count - 1)
                {
                    photoManager.selectedImageIndex = 0;
                }
                else
                {
                    photoManager.selectedImageIndex++;
                }
                updatePictureBoxImage();
            }
        }

        private void comboBoxWhichClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxWhichClass.SelectedIndex == 0)
            {
                statusDebug1.Text = "MWF";
                classList = new ClassList(mwfNames);
            }
            else
            {
                statusDebug1.Text = "TTh";
                classList = new ClassList(tthNames);
            }

            photoManager = new PhotoManager(classList);
        }

        private void tabPageSetup_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }

        private void updatePictureBoxImage()
        {
            pictureBox1.Image = new Bitmap(photoManager.GetSelectedImage());
        }
    }
}
