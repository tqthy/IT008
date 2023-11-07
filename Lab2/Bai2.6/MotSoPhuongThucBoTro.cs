using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;


namespace Bai2._6
{
    public class MotSoPhuongThucBoTro
    {
        public static string fomatDateTimePicker(DateTimePicker dateTimePicker)
        {
            DateTime selectedDate = dateTimePicker.Value;
            string formattedDate = selectedDate.ToString("yyyy/MM/dd");
            return formattedDate;
        }


        //kiểm tra 1 kí tự có phải chữ k
        public static bool checkKiTuChu(char c)
        {
            if ((c >= 65 && c <= 90) || (c >= 97 && (c <= 122)))
            {
                return true;
            }
            return false;
        }

        //kiểm tra 1 kí tự có phải số k
        public static bool checkKiTuSo(char c)
        {
            if ((c >= 48 && c <= 57))
            {
                return true;
            }
            return false;
        }


        //MSSV không được để trống,có đúng 8 kí tự, và mỗi kí tự chỉ có thể là số hoặc chữ
        public static bool checkMSSV(string MSSV)
        {
            if (MSSV.Length != 8)
            {
                return false;
            }

            foreach(char c in MSSV)
            {
                if (!((checkKiTuChu(c))||(checkKiTuSo(c))))
                {
                    return false;
                }
            }
            return true;
        }

        //họ tên không được để trống, k quá 50 kí tự 
        public static bool checkHoTen(string HoTen)
        {
            if((HoTen.Length==0)||(HoTen.Length>50))
            {
                return false;
            }
            return true;
        }


        //địa chỉ không được để trống,k quá 70 kí tự
        public static bool checkDiaChi(string DiaChi)
        {
            if ((DiaChi.Length == 0) || (DiaChi.Length > 70))
            {
                return false;
            }

            return true;
        }


        //sdt không được để trống,chỉ chấp nhận có kí tự số, sđt phải có trên 8 số k quá 20 số
        public static bool checkSDT(string SDT)
        {
            if (SDT.Length<9||SDT.Length>20)
            {
                return false;
            }
            foreach (char c in SDT)
            {
                if (!(checkKiTuSo(c)))
                {
                    return false;
                }
            }
            return true;
        }

        //email không hợp lệ
        public static bool checkEmail(string email)
        {
            if ((email.Length == 0) || (email.Length > 50))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }


        //phục vụ cho việc xử lý ngoại lệ cho ràng buộc unique ở form ThemSinhVien
        public static bool findUnique(string s)
        {
            s = s.ToLower();
            if (s.Contains("unique"))
            {
                return true;
            }
            return false;
        }

    }
}
