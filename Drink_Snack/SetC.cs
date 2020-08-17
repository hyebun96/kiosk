using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class SetC : Form
    {
        public SetC()
        {
            InitializeComponent();
        }

        private void SetC_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox4.Text != null && textBox5.Text != null)
            {
                string connStr = string.Format("server=localhost;" + "user=root;" + "password=apmsetup;" + "database=csharpdb");
                MySqlConnection conn = new MySqlConnection(connStr);

                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        int total = (Convert.ToInt32(textBox1.Text) * 1000) + (Convert.ToInt32(textBox2.Text) * 500) +
                            (Convert.ToInt32(textBox3.Text) * 100) + (Convert.ToInt32(textBox4.Text) * 50) + (Convert.ToInt32(textBox5.Text) * 10);
                        string sql1 = "update havem set m_1000 = " + textBox1.Text + " where day = " + System.DateTime.Now.ToString("yyyyMMdd") + ";";
                        string sql2 = "update havem set m_500 = " + textBox2.Text + " where day = " + System.DateTime.Now.ToString("yyyyMMdd") + ";";
                        string sql3 = "update havem set m_100 = " + textBox3.Text + " where day = " + System.DateTime.Now.ToString("yyyyMMdd") + ";";
                        string sql4 = "update havem set m_50 = " + textBox4.Text + " where day = " + System.DateTime.Now.ToString("yyyyMMdd") + ";";
                        string sql5 = "update havem set m_10 = " + textBox5.Text + " where day = " + System.DateTime.Now.ToString("yyyyMMdd") + ";";
                        string sql6 = "update havem set total = " + total + " where day = " + System.DateTime.Now.ToString("yyyyMMdd") + ";";
                        MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                        MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                        MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                        MySqlCommand cmd4 = new MySqlCommand(sql4, conn);
                        MySqlCommand cmd5 = new MySqlCommand(sql5, conn);
                        MySqlCommand cmd6 = new MySqlCommand(sql6, conn);
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                        cmd4.ExecuteNonQuery();
                        cmd5.ExecuteNonQuery();
                        cmd6.ExecuteNonQuery();
                        MessageBox.Show("입력 성공");
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                }
            }
            this.Close();

            DrinkDAO.Get_DB();
        }
    }
}
