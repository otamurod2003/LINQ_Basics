using System.Diagnostics;
using System.Xml.Serialization;

namespace _01_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq1();
            //Linq2();
            Linq3();
        }

        

        public static void Linq1()
        {
            int[] numbers = { 2, 5, 6, 4, 9, 8, 48, 99, 45, 32, 21, 27 };
            var natijaviySon = from number in numbers
                               where (number > 5)
                               orderby number
                               select number;
            foreach (int number in natijaviySon)
            {
                Console.WriteLine(number.ToString());
            }
        }

        public static void Linq2()
        {
            List<string> strings= new List<string>();
            strings.Add("a");
            strings.Add("adadsdftyuyuiyuiyui");
            strings.Add("adadsdfeewew");
            strings.Add("adassa");
            strings.Add("asswswe");
            strings.Add("adadsdf");
            strings.Add("assdeededgu");                
            strings.Add("h");
            strings.Add("i");
            strings.Add("i");
            var ResultStr =  from str in strings 
                             where str.StartsWith("a") && str.Contains("ada")
                             orderby str descending
                             select str;
            foreach(var str in ResultStr)
            {
                Console.WriteLine(str);
            }
        }
        private class MyFileInfo
        {
            public string Name;
            public long Length;
            public DateTime CreationTime;
        }

        static void Linq3()
        {
            var files = new DirectoryInfo("D:\\Text_files").GetFiles();

            var request = from file in files
                          where file.Length > 1
                          orderby file.Name, file.CreationTime
                          select new MyFileInfo
                          {
                              Name = file.Name,
                              Length = file.Length,
                              CreationTime = file.CreationTime,
                          };
             foreach(var file in request)
            {
                Console.WriteLine
                    (
                        "{0} faylining o'lchami: {1} bayt, yaratilgan vaqti: {2}",
                        file.Name,file.Length,file.CreationTime
                    );
            }               

        }
    }
    }

