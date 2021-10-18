namespace newsletter_photo_organizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSetup = new System.Windows.Forms.TabPage();
            this.btnSetupTabNext = new System.Windows.Forms.Button();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSourceFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxWhichClass = new System.Windows.Forms.ComboBox();
            this.tabPageSelection = new System.Windows.Forms.TabPage();
            this.groupBoxStudentList = new System.Windows.Forms.GroupBox();
            this.listBoxStudentsNotRepresented = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPageOverview = new System.Windows.Forms.TabPage();
            this.tabPageRenaming = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusDebug1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageSetup.SuspendLayout();
            this.tabPageSelection.SuspendLayout();
            this.groupBoxStudentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSetup);
            this.tabControl1.Controls.Add(this.tabPageSelection);
            this.tabControl1.Controls.Add(this.tabPageOverview);
            this.tabControl1.Controls.Add(this.tabPageRenaming);
            this.tabControl1.Location = new System.Drawing.Point(14, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 449);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tabPageSetup
            // 
            this.tabPageSetup.Controls.Add(this.btnSetupTabNext);
            this.tabPageSetup.Controls.Add(this.btnBrowseFolder);
            this.tabPageSetup.Controls.Add(this.label2);
            this.tabPageSetup.Controls.Add(this.tbxSourceFolder);
            this.tabPageSetup.Controls.Add(this.label1);
            this.tabPageSetup.Controls.Add(this.comboBoxWhichClass);
            this.tabPageSetup.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetup.Name = "tabPageSetup";
            this.tabPageSetup.Size = new System.Drawing.Size(767, 423);
            this.tabPageSetup.TabIndex = 3;
            this.tabPageSetup.Text = "Setup";
            this.tabPageSetup.UseVisualStyleBackColor = true;
            this.tabPageSetup.Click += new System.EventHandler(this.tabPageSetup_Click);
            // 
            // btnSetupTabNext
            // 
            this.btnSetupTabNext.Location = new System.Drawing.Point(588, 152);
            this.btnSetupTabNext.Name = "btnSetupTabNext";
            this.btnSetupTabNext.Size = new System.Drawing.Size(75, 23);
            this.btnSetupTabNext.TabIndex = 5;
            this.btnSetupTabNext.Text = "Next";
            this.btnSetupTabNext.UseVisualStyleBackColor = true;
            this.btnSetupTabNext.Click += new System.EventHandler(this.btnSetupTabNext_Click);
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(588, 84);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFolder.TabIndex = 4;
            this.btnBrowseFolder.Text = "Browse...";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Where are the photos?";
            // 
            // tbxSourceFolder
            // 
            this.tbxSourceFolder.Location = new System.Drawing.Point(183, 86);
            this.tbxSourceFolder.Name = "tbxSourceFolder";
            this.tbxSourceFolder.Size = new System.Drawing.Size(399, 20);
            this.tbxSourceFolder.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Which class?";
            // 
            // comboBoxWhichClass
            // 
            this.comboBoxWhichClass.FormattingEnabled = true;
            this.comboBoxWhichClass.Items.AddRange(new object[] {
            "M-W-F",
            "T-Th"});
            this.comboBoxWhichClass.Location = new System.Drawing.Point(183, 35);
            this.comboBoxWhichClass.Name = "comboBoxWhichClass";
            this.comboBoxWhichClass.Size = new System.Drawing.Size(399, 21);
            this.comboBoxWhichClass.TabIndex = 0;
            this.comboBoxWhichClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxWhichClass_SelectedIndexChanged);
            // 
            // tabPageSelection
            // 
            this.tabPageSelection.Controls.Add(this.groupBoxStudentList);
            this.tabPageSelection.Controls.Add(this.pictureBox1);
            this.tabPageSelection.Controls.Add(this.listView1);
            this.tabPageSelection.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelection.Name = "tabPageSelection";
            this.tabPageSelection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelection.Size = new System.Drawing.Size(767, 423);
            this.tabPageSelection.TabIndex = 0;
            this.tabPageSelection.Text = "Selection";
            this.tabPageSelection.UseVisualStyleBackColor = true;
            // 
            // groupBoxStudentList
            // 
            this.groupBoxStudentList.Controls.Add(this.label3);
            this.groupBoxStudentList.Controls.Add(this.listBoxStudentsNotRepresented);
            this.groupBoxStudentList.Location = new System.Drawing.Point(525, 16);
            this.groupBoxStudentList.Name = "groupBoxStudentList";
            this.groupBoxStudentList.Size = new System.Drawing.Size(200, 342);
            this.groupBoxStudentList.TabIndex = 2;
            this.groupBoxStudentList.TabStop = false;
            this.groupBoxStudentList.Text = "Students";
            // 
            // listBoxStudentsNotRepresented
            // 
            this.listBoxStudentsNotRepresented.FormattingEnabled = true;
            this.listBoxStudentsNotRepresented.Location = new System.Drawing.Point(7, 177);
            this.listBoxStudentsNotRepresented.Name = "listBoxStudentsNotRepresented";
            this.listBoxStudentsNotRepresented.Size = new System.Drawing.Size(187, 160);
            this.listBoxStudentsNotRepresented.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 219);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(488, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.Location = new System.Drawing.Point(4, 22);
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.Size = new System.Drawing.Size(767, 423);
            this.tabPageOverview.TabIndex = 2;
            this.tabPageOverview.Text = "Overview";
            this.tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // tabPageRenaming
            // 
            this.tabPageRenaming.Location = new System.Drawing.Point(4, 22);
            this.tabPageRenaming.Name = "tabPageRenaming";
            this.tabPageRenaming.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRenaming.Size = new System.Drawing.Size(767, 423);
            this.tabPageRenaming.TabIndex = 1;
            this.tabPageRenaming.Text = "Renaming";
            this.tabPageRenaming.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDebug1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusDebug1
            // 
            this.statusDebug1.Name = "statusDebug1";
            this.statusDebug1.Size = new System.Drawing.Size(79, 17);
            this.statusDebug1.Text = "statusDebug1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Students Left Out:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "The Amazing Newsletter Photo Organizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSetup.ResumeLayout(false);
            this.tabPageSetup.PerformLayout();
            this.tabPageSelection.ResumeLayout(false);
            this.groupBoxStudentList.ResumeLayout(false);
            this.groupBoxStudentList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSetup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxWhichClass;
        private System.Windows.Forms.TabPage tabPageSelection;
        private System.Windows.Forms.TabPage tabPageOverview;
        private System.Windows.Forms.TabPage tabPageRenaming;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSourceFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSetupTabNext;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusDebug1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBoxStudentList;
        private System.Windows.Forms.ListBox listBoxStudentsNotRepresented;
        private System.Windows.Forms.Label label3;
    }
}

