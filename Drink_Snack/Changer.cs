using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Changer
    {
        public static void buy()
        {
            // 남은 음료의 수 계산
            for (int i = 0; i < Zapangi.d_amount; i++)
            {
                Zapangi.LEFT_D[i] -= Zapangi.BUY_D[i];
            }

            // 남은 스낵의 수 계산
            for (int i = 0; i < Zapangi.s_amount; i++)
            {
                Zapangi.LEFT_S[i] -= Zapangi.BUY_S[i];
            }

            // DB에 저장

            DrinkDAO.Change_DAO();
            DrinkDAO.Get_DB();
        }
    }
}
