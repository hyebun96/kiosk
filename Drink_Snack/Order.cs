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
    public partial class Order : Form
    {
        private int roomNumber;

        // 폼 초기화
        public Order(int room = 0)
        {
            InitializeComponent();

            RoomNum.Text = room.ToString();

            DrinkDAO.Get_DB();

            for (int i = 0; i < Zapangi.d_amount; i++)
            {
                Zapangi.DRINK_B_LIST[i] = Zapangi.DRINK_LIST[i];
            }

            for (int i = 0; i < Zapangi.s_amount; i++)
            {
                Zapangi.SNACK_B_LIST[i] = Zapangi.SNACK_LIST[i];
            }

            Set_image();
            Set_price();
        }

        // 이미지 초기화
        public void Set_image()
        {
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

                            else if (Zapangi.SNACK_LIST[i] == "ICECOOL")
                            {
                                pictureBox5.Image = Properties.Resources.아이스쿨;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "SHRIMP")
                            {
                                pictureBox5.Image = Properties.Resources.새우깡;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "SHORT")
                            {
                                pictureBox5.Image = Properties.Resources.숏다리;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "HARIBO")
                            {
                                pictureBox5.Image = Properties.Resources.하리보;
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
                            else if (Zapangi.SNACK_LIST[i] == "ICECOOL")
                            {
                                pictureBox6.Image = Properties.Resources.아이스쿨;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "SHRIMP")
                            {
                                pictureBox6.Image = Properties.Resources.새우깡;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "SHORT")
                            {
                                pictureBox6.Image = Properties.Resources.숏다리;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "HARIBO")
                            {
                                pictureBox6.Image = Properties.Resources.하리보;
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

                            else if (Zapangi.SNACK_LIST[i] == "ICECOOL")
                            {
                                pictureBox7.Image = Properties.Resources.아이스쿨;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "SHRIMP")
                            {
                                pictureBox7.Image = Properties.Resources.새우깡;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "SHORT")
                            {
                                pictureBox7.Image = Properties.Resources.숏다리;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "HARIBO")
                            {
                                pictureBox7.Image = Properties.Resources.하리보;
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

                            else if (Zapangi.SNACK_LIST[i] == "ICECOOL")
                            {
                                pictureBox8.Image = Properties.Resources.아이스쿨;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "SHRIMP")
                            {
                                pictureBox8.Image = Properties.Resources.새우깡;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "SHORT")
                            {
                                pictureBox8.Image = Properties.Resources.숏다리;
                            }

                            else if (Zapangi.SNACK_LIST[i] == "HARIBO")
                            {
                                pictureBox8.Image = Properties.Resources.하리보;
                            }

                            break;
                        }
                }
            }
        }

        // 가격 라벨 초기화
        public void Set_price()
        {
            drink1.Text = Convert.ToString(Zapangi.DRINK_PRICE[0]) + "원";
            drink2.Text = Convert.ToString(Zapangi.DRINK_PRICE[1]) + "원";
            drink3.Text = Convert.ToString(Zapangi.DRINK_PRICE[2]) + "원";
            drink4.Text = Convert.ToString(Zapangi.DRINK_PRICE[3]) + "원";

            snack1.Text = Convert.ToString(Zapangi.SNACK_PRICE[0]) + "원";
            snack2.Text = Convert.ToString(Zapangi.SNACK_PRICE[1]) + "원";
            snack3.Text = Convert.ToString(Zapangi.SNACK_PRICE[2]) + "원";
            snack4.Text = Convert.ToString(Zapangi.SNACK_PRICE[3]) + "원";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 주문
        private void InputBtn_Click(object sender, EventArgs e)
        {
            Zapangi.ROOM = Convert.ToInt32(RoomNum.Text);

            Zapangi.BUY_D[0] = Convert.ToInt32(drink_a1.Text);
            Zapangi.BUY_D[1] = Convert.ToInt32(drink_a2.Text);
            Zapangi.BUY_D[2] = Convert.ToInt32(drink_a3.Text);
            Zapangi.BUY_D[3] = Convert.ToInt32(drink_a4.Text);

            Zapangi.BUY_S[0] = Convert.ToInt32(snack_a1.Text);
            Zapangi.BUY_S[1] = Convert.ToInt32(snack_a2.Text);
            Zapangi.BUY_S[2] = Convert.ToInt32(snack_a3.Text);
            Zapangi.BUY_S[3] = Convert.ToInt32(snack_a4.Text);

            Changer.buy();

            this.Close();
        }

        // - 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(drink_a1.Text) > 0)
            {
                drink_a1.Text = (Convert.ToInt32(drink_a1.Text) - 1).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(drink_a2.Text) > 0)
            {
                drink_a2.Text = (Convert.ToInt32(drink_a2.Text) - 1).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(drink_a3.Text) > 0)
            {
                drink_a3.Text = (Convert.ToInt32(drink_a3.Text) - 1).ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(drink_a4.Text) > 0)
            {
                drink_a4.Text = (Convert.ToInt32(drink_a4.Text) - 1).ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(snack_a1.Text) > 0)
            {
                snack_a1.Text = (Convert.ToInt32(snack_a1.Text) - 1).ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(snack_a2.Text) > 0)
            {
                snack_a2.Text = (Convert.ToInt32(snack_a2.Text) - 1).ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(snack_a3.Text) > 0)
            {
                snack_a3.Text = (Convert.ToInt32(snack_a3.Text) - 1).ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(snack_a4.Text) > 0)
            {
                snack_a4.Text = (Convert.ToInt32(snack_a4.Text) - 1).ToString();
            }
        }

        // + 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            if (Zapangi.LEFT_D[0] > Convert.ToInt32(drink_a1.Text))
                drink_a1.Text = (Convert.ToInt32(drink_a1.Text) + 1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Zapangi.LEFT_D[1] > Convert.ToInt32(drink_a2.Text))
                drink_a2.Text = (Convert.ToInt32(drink_a2.Text) + 1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Zapangi.LEFT_D[2] > Convert.ToInt32(drink_a3.Text))
                drink_a3.Text = (Convert.ToInt32(drink_a3.Text) + 1).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Zapangi.LEFT_D[3] > Convert.ToInt32(drink_a4.Text))
                drink_a4.Text = (Convert.ToInt32(drink_a4.Text) + 1).ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Zapangi.LEFT_S[0] > Convert.ToInt32(snack_a1.Text))
                snack_a1.Text = (Convert.ToInt32(snack_a1.Text) + 1).ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Zapangi.LEFT_S[1] > Convert.ToInt32(snack_a2.Text))
                snack_a2.Text = (Convert.ToInt32(snack_a2.Text) + 1).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Zapangi.LEFT_S[2] > Convert.ToInt32(snack_a3.Text))
                snack_a3.Text = (Convert.ToInt32(snack_a3.Text) + 1).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Zapangi.LEFT_S[3] > Convert.ToInt32(snack_a4.Text))
                snack_a4.Text = (Convert.ToInt32(snack_a4.Text) + 1).ToString();
        }
    }
}
