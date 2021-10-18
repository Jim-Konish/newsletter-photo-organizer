using System;
using System.Collections.Generic;
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

        private Dictionary<int, CheckBox> shortcuts = new Dictionary<int, CheckBox>();

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

            int[] keys =
            {
                (int)Keys.D1,
                (int)Keys.D2,
                (int)Keys.D3,
                (int)Keys.D4,
                (int)Keys.D5,
                (int)Keys.D6,
                (int)Keys.D7,
                (int)Keys.D8,
                (int)Keys.D9,
                (int)Keys.D0,
            };

            int keyIndex = 0;

            int shortcutKey = 1;
            foreach (var student in classList.Students)
            {
                // Add student to list on next tab
                student.MyCheckBox = new CheckBox();
                CheckBox box = student.MyCheckBox;
                box.Text = "(" + shortcutKey.ToString() + ") " + student.Name;
                groupBoxStudentList.Controls.Add(box);
                box.Top = yOffset;
                box.Left = xOffset;
                box.CheckedChanged += CheckBoxCheckedChanged;
                yOffset += 20;

                shortcuts.Add(keys[keyIndex], box);
                
                shortcutKey++;
                keyIndex++;

                // If there are 10 students in the class, we'll need to use 0 for the tenth one
                if(shortcutKey > 9)
                {
                    shortcutKey = 0;
                }

                if(student.MyCheckBox == null)
                {
                    throw new NullReferenceException("MyCheckBox cannot be NULL");
                }
            }
            updateSelectedClass();
            UpdateAbsentStudents();
            photoManager.LoadImages(tbxSourceFolder.Text);
            
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            updatePictureBoxImage();
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
                shortcuts[e.KeyValue].Checked = !shortcuts[e.KeyValue].Checked;
                photoManager.UpdateAllStudents();
                UpdateAbsentStudents();
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
            if (e.KeyValue == (int)Keys.Space)
            {
                photoManager.GetSelectedImage().ToggleStarred();

                photoManager.UpdateAllStudents();

                statusDebug1.Text = (photoManager.GetSelectedImage().Starred) ? "Starred" : "Unstarred";
            }
        }

        private void comboBoxWhichClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSelectedClass();
        }

        private void updateSelectedClass()
        {
            List<string> classNames;
            if (comboBoxWhichClass.SelectedIndex == 0)
            {
                classNames = new List<string>(mwfNames);
            }
            else
            {
                classNames = new List<string>(tthNames);
            }
            classList = new ClassList(classNames);
            photoManager = new PhotoManager(classList);
        }

        private void UpdateAbsentStudents()
        {
            foreach (Student student in classList.Students)
            {
                if(student.Count == 0)
                {
                    if (!listBoxStudentsNotRepresented.Items.Contains(student.Name))
                    {
                        listBoxStudentsNotRepresented.Items.Add(student.Name);
                    }
                }
                else if(listBoxStudentsNotRepresented.Items.Contains(student.Name))
                {
                    listBoxStudentsNotRepresented.Items.Remove(student.Name);
                }
            }
        }

        private void tabPageSetup_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }

        private void updatePictureBoxImage()
        {
            pictureBox1.Image = new Bitmap(photoManager.GetSelectedImage().PathName);
        }

        private void CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            statusStrip1.Text += " CHANGED";
            CheckBox box = (CheckBox)sender;
            foreach (Student student in classList.Students)
            {
                if(box == student.MyCheckBox)
                {
                    // The checked state of the box determines whether this student is present
                    // in this photo.
                    photoManager.GetSelectedImage().studentPresence[student] = box.Checked;
                }
            }

            // Update the counts for all students
            photoManager.UpdateAllStudents();

            // Update the absent students list
            UpdateAbsentStudents();
        }
    }
}
