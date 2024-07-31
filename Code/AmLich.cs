using System;

namespace Code
{
    public class AmLich
    {
        public static String CanChi(int Nam)
        {
            if (Nam < 0) return "Không hợp lệ";
            String[] Can = new String[10] { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
            String[] Chi = new String[12] { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tị", "Ngọ", "Mùi" };
            return Can[Nam % 10] + " " + Chi[Nam % 12];
        }
    }
}
