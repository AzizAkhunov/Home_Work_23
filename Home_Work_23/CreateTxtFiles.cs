using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_23
{
    public static class CreateTxtFilesAndWrite
    {
        public static void CreateFiles_10()
        {
            // Yangi fayl ochish va yozish
            for (int i = 0; i < 10; i++)
            {
            string cn = Convert.ToString(i);
            string path = $@"C:\\Users\\aziza\\source\\repos\\Home_Work_23\\Home_Work_23\\TxtFiles\\txt{cn}.txt";
            var f1 = new FileInfo(path);
                using (StreamWriter sw = f1.CreateText())
                {
                    sw.WriteLine(i);
                }
            }
        }


        public static void ReadAllFiles()
        {
            // fayl ochish va Uqish
            for (int i = 0; i < 10; i++)
            {
            string cn = Convert.ToString(i);
            string path = $@"C:\\Users\\aziza\\source\\repos\\Home_Work_23\\Home_Work_23\\TxtFiles\\txt{i}.txt";
            var f1 = new FileInfo(path);
            
                using (StreamReader sr = f1.OpenText())
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

        }
                
    }
}
