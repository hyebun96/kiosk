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
    public partial class SetD : Form
    {
        Order form;

        public SetD()
        {
            InitializeComponent();
            Set_image();
        }

        public void Set_image()
        {
            // 음료 이미지 세팅
            for (int i = 0; i < Zapangi.d_amount; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            if (Zapangi.DRINK_LIST[i] == "COKE")
                            {
                                pictureBox1.Image = Properties.Resources.콜라;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "FANTA")
                            {
                                pictureBox1.Image = Properties.Resources.환타;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "COFFEE")
                            {
                                pictureBox1.Image = Properties.Resources.커피;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "WATER")
                            {
                                pictureBox1.Image = Properties.Resources.물;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "ALOE")
                            {
                                pictureBox1.Image = Properties.Resources.알로에쥬스;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "MANGO")
                            {
                                pictureBox1.Image = Properties.Resources.망고쥬스;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "WELCHS")
                            {
                                pictureBox1.Image = Properties.Resources.웰치스;
                            }
                            break;
                        }
                    case 1:
                        {
                            if (Zapangi.DRINK_LIST[i] == "COKE")
                            {
                                pictureBox2.Image = Properties.Resources.콜라;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "FANTA")
                            {
                                pictureBox2.Image = Properties.Resources.환타;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "COFFEE")
                            {
                                pictureBox2.Image = Properties.Resources.커피;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "WATER")
                            {
                                pictureBox2.Image = Properties.Resources.물;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "ALOE")
                            {
                                pictureBox2.Image = Properties.Resources.알로에쥬스;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "MANGO")
                            {
                                pictureBox2.Image = Properties.Resources.망고쥬스;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "WELCHS")
                            {
                                pictureBox2.Image = Properties.Resources.웰치스;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (Zapangi.DRINK_LIST[i] == "COKE")
                            {
                                pictureBox3.Image = Properties.Resources.콜라;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "FANTA")
                            {
                                pictureBox3.Image = Properties.Resources.환타;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "COFFEE")
                            {
                                pictureBox3.Image = Properties.Resources.커피;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "WATER")
                            {
                                pictureBox3.Image = Properties.Resources.물;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "ALOE")
                            {
                                pictureBox3.Image = Properties.Resources.알로에쥬스;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "MANGO")
                            {
                                pictureBox3.Image = Properties.Resources.망고쥬스;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "WELCHS")
                            {
                                pictureBox3.Image = Properties.Resources.웰치스;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (Zapangi.DRINK_LIST[i] == "COKE")
                            {
                                pictureBox4.Image = Properties.Resources.콜라;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "FANTA")
                            {
                                pictureBox4.Image = Properties.Resources.환타;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "COFFEE")
                            {
                                pictureBox4.Image = Properties.Resources.커피;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "WATER")
                            {
                                pictureBox4.Image = Properties.Resources.물;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "ALOE")
                            {
                                pictureBox4.Image = Properties.Resources.알로에쥬스;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "MANGO")
                            {
                                pictureBox4.Image = Properties.Resources.망고쥬스;
                            }

                            else if (Zapangi.DRINK_LIST[i] == "WELCHS")
                            {
                                pictureBox4.Image = Properties.Resources.웰치스;
                            }
                            break;
                        }
                }
            }


            // 스낵 이미지 세팅
            for (int i = 0; i < Zapangi.s_amount; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            if (Zapangi.SNACK_LIST[i] == "HONEY")
                            {
                                pictureBox5.Image = Properties.Resources.허니버터칩;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "STICK")
                            {
                                pictureBox5.Image = Properties.Resources.빼빼로;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "PRINGLE")
                            {
                                pictureBox5.Image = Properties.Resources.프링글스;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "COOKIE")
                            {
                                pictureBox5.Image = Properties.Resources.꾸이꾸이;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "SHRIMP")
                            {
                                pictureBox5.Image = Properties.Resources.새우깡;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "ICECOOL")
                            {
                                pictureBox5.Image = Properties.Resources.아이스쿨;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "HARIBO")
                            {
                                pictureBox5.Image = Properties.Resources.하리보;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "SHORT")
                            {
                                pictureBox5.Image = Properties.Resources.숏다리;
                            }

                            break;
                        }
                    case 1:
                        {
                            if (Zapangi.SNACK_LIST[i] == "HONEY")
                            {
                                pictureBox6.Image = Properties.Resources.허니버터칩;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "STICK")
                            {
                                pictureBox6.Image = Properties.Resources.빼빼로;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "PRINGLE")
                            {
                                pictureBox6.Image = Properties.Resources.프링글스;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "COOKIE")
                            {
                                pictureBox6.Image = Properties.Resources.꾸이꾸이;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "SHRIMP")
                            {
                                pictureBox6.Image = Properties.Resources.새우깡;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "ICECOOL")
                            {
                                pictureBox6.Image = Properties.Resources.아이스쿨;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "HARIBO")
                            {
                                pictureBox6.Image = Properties.Resources.하리보;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "SHORT")
                            {
                                pictureBox6.Image = Properties.Resources.숏다리;
                            }

                            break;
                        }
                    case 2:
                        {
                            if (Zapangi.SNACK_LIST[i] == "HONEY")
                            {
                                pictureBox7.Image = Properties.Resources.허니버터칩;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "STICK")
                            {
                                pictureBox7.Image = Properties.Resources.빼빼로;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "PRINGLE")
                            {
                                pictureBox7.Image = Properties.Resources.프링글스;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "COOKIE")
                            {
                                pictureBox7.Image = Properties.Resources.꾸이꾸이;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "SHRIMP")
                            {
                                pictureBox7.Image = Properties.Resources.새우깡;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "ICECOOL")
                            {
                                pictureBox7.Image = Properties.Resources.아이스쿨;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "HARIBO")
                            {
                                pictureBox7.Image = Properties.Resources.하리보;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "SHORT")
                            {
                                pictureBox7.Image = Properties.Resources.숏다리;
                            }

                            break;
                        }
                    case 3:
                        {
                            if (Zapangi.SNACK_LIST[i] == "HONEY")
                            {
                                pictureBox8.Image = Properties.Resources.허니버터칩;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "STICK")
                            {
                                pictureBox8.Image = Properties.Resources.빼빼로;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "PRINGLE")
                            {
                                pictureBox8.Image = Properties.Resources.프링글스;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "COOKIE")
                            {
                                pictureBox8.Image = Properties.Resources.꾸이꾸이;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "SHRIMP")
                            {
                                pictureBox8.Image = Properties.Resources.새우깡;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "ICECOOL")
                            {
                                pictureBox8.Image = Properties.Resources.아이스쿨;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "HARIBO")
                            {
                                pictureBox8.Image = Properties.Resources.하리보;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "SHORT")
                            {
                                pictureBox8.Image = Properties.Resources.숏다리;
                            }

                            break;
                        }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Zapangi.d_amount; i++)
            {
                Zapangi.DRINK_B_LIST[i] = Zapangi.DRINK_LIST[i];
            }

            for (int i = 0; i < Zapangi.s_amount; i++)
            {
                Zapangi.SNACK_B_LIST[i] = Zapangi.SNACK_B_LIST[i];
            }

            // 음료 가격 수정
            if (checkBox1.Checked)
            {
                if (textBox8.Text != null && textBox7.Text != null && textBox6.Text != null && textBox5.Text != null)
                {
                    Zapangi.DRINK_PRICE[0] = Convert.ToInt32(textBox8.Text);
                    Zapangi.DRINK_PRICE[1] = Convert.ToInt32(textBox7.Text);
                    Zapangi.DRINK_PRICE[2] = Convert.ToInt32(textBox6.Text);
                    Zapangi.DRINK_PRICE[3] = Convert.ToInt32(textBox5.Text);
                }
            }

            // 음료 수량 수정
            if (checkBox2.Checked)
            {
                if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox4.Text != null)
                {
                    Zapangi.LEFT_D[0] = Convert.ToInt32(textBox1.Text);
                    Zapangi.LEFT_D[1] = Convert.ToInt32(textBox2.Text);
                    Zapangi.LEFT_D[2] = Convert.ToInt32(textBox4.Text);
                    Zapangi.LEFT_D[3] = Convert.ToInt32(textBox3.Text);
                }
            }

            // 음료 종류 변경
            if (checkBox3.Checked)
            {
                for (int i = 0; i < Zapangi.d_amount; i++)
                {
                    Zapangi.DRINK_B_LIST[i] = Zapangi.DRINK_LIST[i];
                }
                int count = 0;
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    string item = checkedListBox1.CheckedItems[i].ToString();

                    if (item == "콜라")
                    {
                        Zapangi.DRINK_LIST[count++] = "COKE";
                    }
                    else if (item == "환타")
                    {
                        Zapangi.DRINK_LIST[count++] = "FANTA";
                    }
                    else if (item == "커피")
                    {
                        Zapangi.DRINK_LIST[count++] = "COFFEE";
                    }
                    else if (item == "물")
                    {
                        Zapangi.DRINK_LIST[count++] = "WATER";
                    }
                    else if (item == "알로에쥬스")
                    {
                        Zapangi.DRINK_LIST[count++] = "ALOE";
                    }
                    else if (item == "망고쥬스")
                    {
                        Zapangi.DRINK_LIST[count++] = "MANGO";
                    }
                    else if (item == "웰치스")
                    {
                        Zapangi.DRINK_LIST[count++] = "WELCHS";
                    }
                }
            }

            // 스낵 가격 변경
            if (checkBox4.Checked)
            {
                if (textBox16.Text != null && textBox15.Text != null && textBox14.Text != null && textBox13.Text != null)
                {
                    Zapangi.SNACK_PRICE[0] = Convert.ToInt32(textBox16.Text);
                    Zapangi.SNACK_PRICE[1] = Convert.ToInt32(textBox15.Text);
                    Zapangi.SNACK_PRICE[2] = Convert.ToInt32(textBox14.Text);
                    Zapangi.SNACK_PRICE[3] = Convert.ToInt32(textBox13.Text);
                }
            }

            //스낵 수량 변경
            if (checkBox5.Checked)
            {
                if (textBox9.Text != null && textBox10.Text != null && textBox11.Text != null && textBox12.Text != null)
                {
                    Zapangi.LEFT_S[0] = Convert.ToInt32(textBox9.Text);
                    Zapangi.LEFT_S[1] = Convert.ToInt32(textBox10.Text);
                    Zapangi.LEFT_S[2] = Convert.ToInt32(textBox11.Text);
                    Zapangi.LEFT_S[3] = Convert.ToInt32(textBox12.Text);
                }
            }

            //스낵 종류 변경
            if (checkBox6.Checked)
            {
                for (int i = 0; i < Zapangi.s_amount; i++)
                {
                    Zapangi.SNACK_B_LIST[i] = Zapangi.SNACK_LIST[i];
                }
                int count = 0;
                for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
                {
                    string item = checkedListBox2.CheckedItems[i].ToString();

                    if (item == "허니버터칩")
                    {
                        Zapangi.SNACK_LIST[count++] = "HONEY";
                    }
                    else if (item == "빼빼로")
                    {
                        Zapangi.SNACK_LIST[count++] = "STICK";
                    }
                    else if (item == "프링글스")
                    {
                        Zapangi.SNACK_LIST[count++] = "PRINGLE";
                    }
                    else if (item == "꾸이꾸이")
                    {
                        Zapangi.SNACK_LIST[count++] = "COOKIE";
                    }

                    else if (item == "숏다리")
                    {
                        Zapangi.SNACK_LIST[count++] = "SHORT";
                    }

                    else if (item == "하리보")
                    {
                        Zapangi.SNACK_LIST[count++] = "HARIBO";
                    }

                    else if (item == "새우깡")
                    {
                        Zapangi.SNACK_LIST[count++] = "SHRIMP";
                    }

                    else if (item == "아이스쿨")
                    {
                        Zapangi.SNACK_LIST[count++] = "ICECOOL";
                    }
                }
            }

            MessageBox.Show("입력 성공");

            this.Close();

            // 세팅 후 DB변경 및 읽어오기
            DrinkDAO.Change_DAO();
            DrinkDAO.Get_DB();
        }

        private void SetD_Load(object sender, EventArgs e)
        {

        }
    }
}
