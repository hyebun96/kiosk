using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project;
using WindowsFormsApp2;

namespace StudyRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DrinkDAO.Get_DB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            project.studyRoom stu = new project.studyRoom();
            stu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Password pw = new Password();

            pw.Show();
        }
    }
}
