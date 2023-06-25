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
            // Yangi fayl ochish
            for (int i = 0; i < 10; i++)
            {
                string path = $"{Directory.GetCurrentDirectory()}\\Files_Txt\\{i}.txt";
                var f1 = new FileStream(path,FileMode.Create);
                f1.Close();
            }
        }

        public static void Writeto10Files()
        {
            //filega yozish
            for (int i = 0; i < 10; i++)
            {
                var r = new StreamWriter($"{Directory.GetCurrentDirectory()}\\Files_Txt\\{i}.txt", false, Encoding.UTF8);
                r.WriteLine(i);
                r.Close();
            }
        }

        public static void ReadAllFiles()
        {
            //  Uqish
            for (int i = 0; i < 10; i++)
            {
            string path = $"{Directory.GetCurrentDirectory()}\\Files_Txt\\{i}.txt";
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
