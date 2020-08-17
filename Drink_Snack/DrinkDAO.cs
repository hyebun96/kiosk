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
    public class DrinkDAO
    {
        // DB 변경하기
        public static void Change_DAO(int select = 0)
        {
            string connStr = string.Format("server=localhost;" + "user=root;" + "password=apmsetup;" + "database=zapangi");
            MySqlConnection conn = new MySqlConnection(connStr);

            // 업데이트
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    // 음료
                    string sql1 = "update drink set amount = " + (Zapangi.LEFT_D[0]) + ", name  = '" + (Zapangi.DRINK_LIST[0]) + "', price = " + (Zapangi.DRINK_PRICE[0]) + " where name = '" + Zapangi.DRINK_B_LIST[0] + "';";
                    string sql2 = "update drink set amount = " + (Zapangi.LEFT_D[1]) + ", name  = '" + (Zapangi.DRINK_LIST[1]) + "', price = " + (Zapangi.DRINK_PRICE[1]) + " where name = '" + Zapangi.DRINK_B_LIST[1] + "';";
                    string sql3 = "update drink set amount = " + (Zapangi.LEFT_D[2]) + ", name  = '" + (Zapangi.DRINK_LIST[2]) + "', price = " + (Zapangi.DRINK_PRICE[2]) + " where name = '" + Zapangi.DRINK_B_LIST[2] + "';";
                    string sql4 = "update drink set amount = " + (Zapangi.LEFT_D[3]) + ", name  = '" + (Zapangi.DRINK_LIST[3]) + "', price = " + (Zapangi.DRINK_PRICE[3]) + " where name = '" + Zapangi.DRINK_B_LIST[3] + "';";
                    // 스낵
                    string sql5 = "update snack set amount = " + (Zapangi.LEFT_S[0]) + ", name  = '" + (Zapangi.SNACK_LIST[0]) + "', price = " + (Zapangi.SNACK_PRICE[0]) + " where name = '" + Zapangi.SNACK_B_LIST[0] + "';";
                    string sql6 = "update snack set amount = " + (Zapangi.LEFT_S[1]) + ", name  = '" + (Zapangi.SNACK_LIST[1]) + "', price = " + (Zapangi.SNACK_PRICE[1]) + " where name = '" + Zapangi.SNACK_B_LIST[1] + "';";
                    string sql7 = "update snack set amount = " + (Zapangi.LEFT_S[2]) + ", name  = '" + (Zapangi.SNACK_LIST[2]) + "', price = " + (Zapangi.SNACK_PRICE[2]) + " where name = '" + Zapangi.SNACK_B_LIST[2] + "';";
                    string sql8 = "update snack set amount = " + (Zapangi.LEFT_S[3]) + ", name  = '" + (Zapangi.SNACK_LIST[3]) + "', price = " + (Zapangi.SNACK_PRICE[3]) + " where name = '" + Zapangi.SNACK_B_LIST[3] + "';";

                    // 음료
                    MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                    MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                    MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                    MySqlCommand cmd4 = new MySqlCommand(sql4, conn);
                    // 스낵
                    MySqlCommand cmd5 = new MySqlCommand(sql5, conn);
                    MySqlCommand cmd6 = new MySqlCommand(sql6, conn);
                    MySqlCommand cmd7 = new MySqlCommand(sql7, conn);
                    MySqlCommand cmd8 = new MySqlCommand(sql8, conn);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    // 스낵
                    cmd5.ExecuteNonQuery();
                    cmd6.ExecuteNonQuery();
                    cmd7.ExecuteNonQuery();
                    cmd8.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
            }

            conn.Close();
        }

        // DB에서 읽어오기
        public static void Get_DB()
        {
            string connStr = string.Format("server=localhost;" + "user=root;" + "password=apmsetup;" + "database=zapangi");
            MySqlConnection conn = new MySqlConnection(connStr);

            // 관리자 패스워드 세팅
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "select * from login";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    int i = 0;

                    while (rdr.Read())
                    {
                        Zapangi.pass_ad = Convert.ToString(rdr[0]);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                conn.Close();
            }

            conn.Close();

            // 음료 세팅
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "select * from drink";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    int i = 0;

                    while (rdr.Read())
                    {
                        Zapangi.DRINK_LIST[i] = Convert.ToString(rdr[0]);
                        Zapangi.DRINK_PRICE[i] = Convert.ToInt32(rdr[1]);
                        Zapangi.LEFT_D[i] = Convert.ToInt32(rdr[2]);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                conn.Close();
            }

            conn.Close();

            // 스낵 세팅
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string sql = "select * from snack";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    int i = 0;

                    while (rdr.Read())
                    {
                        Zapangi.SNACK_LIST[i] = Convert.ToString(rdr[0]);
                        Zapangi.SNACK_PRICE[i] = Convert.ToInt32(rdr[1]);
                        Zapangi.LEFT_S[i] = Convert.ToInt32(rdr[2]);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                conn.Close();
            }

            conn.Close();
        }
    }
}
