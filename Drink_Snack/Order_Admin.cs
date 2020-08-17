using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Order_Admin : Form
    {
        Order form;
        public Order_Admin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SetD sd = new SetD();

            sd.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SetC sc = new SetC();

            sc.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
