using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2._9
{
    public class MotSoPhuongThucBoTro
    {
        //phương thức check 1 ký tự có được chấp nhận làm tài khoản không
        public static bool kyTuTKChuan(char c)
        {
            if ((c >= 65 && c <= 90) || (c >= 97 && c < 122) || (c >= 48 && c <= 57))
            {
                return true;
            }
            return false;
        }


        //tài khoản chỉ chấp nhận kí tự chữ thường, hoa,hoặc số,số kí tự >=6
        public static bool checkUsername(string username)
        {
            if(username.Length < 6)
            {
                return false;
            }
            foreach(char c in username)
            {
                if (!(kyTuTKChuan(c)))
                {
                    return false;
                }
            }
            return true;
        }

        //phương thức check 1 ký tự có được chấp nhận làm mật khẩu không
        public static bool kyTuMKChuan(char c)
        {
            if (c >= 33 && c <= 126)
            {
                return true;
            }
            return false;
        }

        //mật khẩu chấp nhận thêm cả các kí tự như @,;,.....(trừ dấu cách và 1 số kí tự liên quan đến hệ thống)
        public static bool checkPassword(string password)
        {
            if (password.Length < 5)
            {
                return false;
            }
            foreach(char c in password)
            {
                if (!kyTuMKChuan(c))
                {
                    return false;
                }
            }
            return true;
        }

        //SĐT chỉ được chấp nhận kiểu số
        public static bool checkSDT(string sdt)
        {
            if(sdt.Length != 10)
            {
                return false;
            }
            foreach(char c in sdt)
            {
                if (c < 48 || c > 57)
                {
                    return false;
                }
            }
            return true;
        }
        
        //Số CMND chỉ chấp nhận kiểu số và dao động từ 10 đến 12 số
        public static bool checkSoCMND(string scmnd)
        {
            if(scmnd.Length < 10 || scmnd.Length > 12)
            {
                return false;
            }
            foreach(char c in scmnd)
            {
                if (c < 48 || c > 57)
                {
                    return false;
                }
            }
            return true;
        }


        //kiểm tra 1 username đã được đăng ký chưa(kiểu nếu có rồi thì người dùng k được đăng ký username này)
        //có rồi thì trả về true
        public static bool checkUsernameInData(string username)
        {
            using(FileStream fStream =new FileStream("user.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                using(StreamReader sr = new StreamReader(fStream))
                {
                    string[] decryptedData = AES128.DecryptFromFile("user.txt");
                    foreach (var decryptedString in decryptedData)
                    {
                        string[] userPass = decryptedString.Split(' ');
                        string user = userPass[0];
                        if (user == username)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
        }
    }
}
