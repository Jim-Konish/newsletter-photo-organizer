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

        private ClassList classList;

        
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
            tabControl1.SelectedIndex += 1;
            foreach (var student in classList.students)
            {
                chkLstStudents.Items.Add(student);
            }
            chkLstStudents.DisplayMember = "Name";
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
        }

        private void tabPageSetup_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }
    }

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
