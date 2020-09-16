using System;

namespace Unit1.Project2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            Console.Write("Nhap day du Ten cua ban : ");
            fullName = Console.ReadLine();
            Console.WriteLine("Ten cua ban sau khi dinh dang : {0}", ToFirstUpperCase(fullName));
            Console.ReadLine();
        }

        /// <summary>
        /// In hoa chữ cái đầu tiên trong chuỗi
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns>
        /// Trả về null nếu nhập chuỗi rỗng
        /// </returns>
        public static string ToFirstUpperCase(string fullName)
        {
            if (fullName.Length == 0)
            {
                return null;
            }
            string result = "";
            fullName = RemoveSpace(fullName);
            // Tách chuỗi khi gặp khoảng trắng
            string[] subName = fullName.Split(' ');
            for (int i = 0; i < subName.Length; i++)
            {
                // Lấy chữ cái đầu tiên của từ
                string firstChar = subName[i].Substring(0, 1);
                // Các chữ cái còn lại của từ
                string otherChar = subName[i].Substring(1);
                // In hoa chữ cái đầu tiên và in thường cho các chữ cái còn lại
                subName[i] = firstChar.ToUpper() + otherChar.ToLower();
                result += subName[i] + " ";
            }
            return result.Trim();
        }

        /// <summary>
        /// Xóa khoảng trắng không cần thiết
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        public static string RemoveSpace(string fullName)
        {
            // Cắt khoảng trắng ở 2 đầu chuỗi
            fullName = fullName.Trim();
            // Trong khi còn 2 khoảng trắng thì thay thế bằng 1 khoảng trắng
            while (fullName.IndexOf("  ") != -1)
            {
                fullName = fullName.Replace("  ", " ");
            }
            return fullName;
        }
    }
}
