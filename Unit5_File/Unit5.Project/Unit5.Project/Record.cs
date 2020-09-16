using System;
using System.Collections.Generic;
using System.Text;

namespace Unit5.Project
{
    public class Record
    {
        public Record()
        {

        }
        public List<string> ListError
        {
            get;set;
        }
        public string DateTime { get; set; }
        public string Type { get; set; }

        public string Action { get; set; }

        public Record(string datetime, string type, string action, List<string> listError) 
        {
            DateTime = datetime;
            Type = type;
            Action = action;
            ListError = listError;
        }
        public void ShowInformation()
        {
            Console.WriteLine("Thoi gian : {0}", DateTime);
            Console.WriteLine("Loai file: {0}", Type);
            Console.WriteLine("Hanh dong thuc hien: {0}", Action);
            if (ListError.Count > 0)
            {
                for (int i = 0; i <= ListError.Count; i++)
                {
                    Console.WriteLine("Vi tri cua no", ListError[i]);

                }
            }

        }
    }
}
