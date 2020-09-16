using System;

namespace Unit1.Project5
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Nhap day du Ten cua ban : ");
            str = Console.ReadLine();
            Console.WriteLine("Chuoi sau khi duoc in hoa: {0}", UpperCase(str));
            Console.WriteLine("Chuoi sau khi duoc in thuong: {0} ", LowerCase(str));
            Console.WriteLine("Viet hoa chu cai dau tien cua chuoi: {0} ", CapitalizeEachWord(str));
            Console.WriteLine("Viet thuong chu cai dau tien, cac chu sau viet hoa: {0} ", ToLastUpperCase(str));
            Console.WriteLine("Viet hoa chu cai dau tien sau dau cham: {0} ", SentenseCase(str));
            Console.ReadLine();
        }

        /// <summary>
        /// Xóa khoảng trắng không cần thiết
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveSpace(string str)
        {
            // Cắt khoảng trắng ở 2 đầu chuỗi
            str = str.Trim();
            // Trong khi còn 2 khoảng trắng thì thay thế bằng 1 khoảng trắng
            while (str.IndexOf("  ") != -1)
            {
                str = str.Replace("  ", " ");
            }
            return str;
        }

        /// <summary>
        /// In hoa toàn bộ chuỗi
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string UpperCase(string str)
        {
            str = RemoveSpace(str);
            string uppercase = str.ToUpper();
            return uppercase;
        }

        /// <summary>
        /// In thường toàn bộ chuỗi
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string LowerCase(string str)
        {
            str = RemoveSpace(str);
            string lowercase = str.ToLower();
            return lowercase;
        }

        /// <summary>
        /// In hoa chữ cái đầu tiên
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string CapitalizeEachWord(string str)
        {
            string result = "";
            str = RemoveSpace(str);
            // Tách chuỗi khi gặp khoảng trắng
            string[] subName = str.Split(' ');
            for (int i = 0; i < subName.Length; i++)
            {
                result += subName[i] = subName[i].Substring(0, 1).ToUpper() + subName[i].Substring(1).ToLower() + " ";
            }
            return result;
        }

        /// <summary>
        /// Chữ cái đầu tiên in thường, còn lại các chữ cái in hoa
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToLastUpperCase(string str)
        {
            string result = "";
            str = RemoveSpace(str);
            string[] subName = str.Split(' ');
            for (int i = 0; i < subName.Length; i++)
            {
                result += subName[i].Substring(0, 1).ToLower() + subName[i].Substring(1).ToUpper() + " ";
            }
            return result;
        }

        /// <summary>
        /// In hoa chữ cái sau dấu chấm
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string SentenseCase(string str)
        {
            string result = "";
            str = RemoveSpace(str);
            // Tách chuỗi khi gặp dấu chấm
            string[] subName = str.Split('.');
            for (int i = 1; i < subName.Length; i++)
            {
                if (subName[i] != "")
                {
                    subName[i] = subName[i].Substring(0, 1).ToUpper() + subName[i].Substring(1);
                    result += '.' + subName[i];
                }
            }
            return result;
        }
    }
}
