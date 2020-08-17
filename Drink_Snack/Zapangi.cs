using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Zapangi
    {
        private static int D_AMOUNT = 4; // 음료의 종류 수
        private static int S_AMOUNT = 4; // 스낵의 종류 수

        public static int[] DRINK_PRICE = new int[D_AMOUNT]; // 음료의 가격
        public static string[] DRINK_LIST = new string[D_AMOUNT]; // 음료의 종류
        public static string[] DRINK_B_LIST = new string[D_AMOUNT]; // 변경 전 음료
        public static int[] LEFT_D = new int[D_AMOUNT]; // 남은 음료의 수

        public static int[] SNACK_PRICE = new int[S_AMOUNT]; // 스낵의 가격
        public static string[] SNACK_LIST = new string[S_AMOUNT]; // 스낵의 종류
        public static string[] SNACK_B_LIST = new string[S_AMOUNT]; // 변경 전 스낵
        public static int[] LEFT_S = new int[S_AMOUNT]; // 남은 스낵의 수

        public static int ROOM;

        public static int[] BUY_D = new int[D_AMOUNT]; // 구매한 음료의 수
        public static int[] BUY_S = new int[S_AMOUNT]; // 구매한 음료의 수

        public static int d_amount { get { return D_AMOUNT; } }
        public static int s_amount { get { return S_AMOUNT; } }

        private static string PASS_AD; // 관리자 모드 비밀번호
        public static string pass_ad { get { return PASS_AD; } set { PASS_AD = value; } }


    }
}
