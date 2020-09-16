using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Unit5.Project
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:/Users/Admin//log.txt";
            List<Record> records = new List<Record>();
            string regexDate = "(\\d{4})-(\\d{2})-(\\d{2}) (\\d{2}):(\\d{2}):(\\d{2}),(\\d{3})";
            string regexType = "(INFO|ERROR)";
            string[] list;
            string temp;

            if (File.Exists(path)) 
            { 
                list = File.ReadAllLines(path);
                for (int i = 0; i < list.Length; i++)
                {
                    if (Regex.Match(list[i], regexDate).ToString() != "")
                    {
                        var position = new List<string>();
                        Match date = Regex.Match(list[i], regexDate);
                        Match type = Regex.Match(list[i], regexType);
                        string action = list[i].Substring(list[i].IndexOf(" - ") + 3);
                        if (type.ToString() == "ERROR")
                        {
                            int j = i + 1;
                            while (j < list.Length && list[j].Contains(" at"))
                            {
                                temp = list[j].Substring(list[j].IndexOf(" at"));
                                position.Add(temp);
                                j++;
                            }
                            i = j - 1;
                        }
                        records.Add(new Record(date.ToString(), type.ToString(), action, position));
                    }
                }         
                // Danh sách INFO
                List<Record> listInfo = records.Where(x => x.Type == "INFO").ToList();
                // Danh sách ERROR
                List<Record> listError = records.Where(x => x.Type == "ERROR").ToList();
                Console.WriteLine("New ERROR");
                // Phần tử error mới nhất là phần tử xuống hiện cuối cùng trong file
                Record newError = records.LastOrDefault(x => x.Type == "ERROR");
                newError.ShowInformation();

                // ** Xử lý xml
                // Biến đổi object về xml
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Record>));
                // Tạo mới file
                TextWriter fileStream = new StreamWriter(@"G:/output.xml");
                // Ghi dữ liệu vào file
                xmlSerializer.Serialize(fileStream, records);
                // Đóng file
                fileStream.Close();
            }
            else
            {
                Console.WriteLine("Khong ton tai file");
            }
        }
    }
}
