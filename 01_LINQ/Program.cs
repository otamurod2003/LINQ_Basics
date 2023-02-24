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
            //Linq3();
            //Linq3_2();
            //Linq4();
            //Linq5();
            //Linq6();
            Linq7();
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

        static void Linq3_2()
        {
            var files = new DirectoryInfo("D:\\Text_files").GetFiles();

            var request = from file in files
                          where file.Length > 1
                          orderby file.Name, file.CreationTime
                          select new 
                          {
                              Name = file.Name,
                              Length = file.Length,
                              CreationTime = file.CreationTime,
                          };
            foreach (var file in request)
            {
                Console.WriteLine
                    (
                        "{0} faylining o'lchami: {1} bayt, yaratilgan vaqti: {2}",
                        file.Name, file.Length, file.CreationTime
                    );
            }

        }
        //4-misol Extension metodlar 
        //Extension metodlar deganda biron bir massivdan qanchadir miqdordagi elementni olib ko'rsatish haqida ilgari suradi
        // Take operatori massiv elementlarini boshidan berilgan qiymatiga qarab natijani qaytarib berish vazifasini bajaradi
        static void Linq4()
        {
            int[] numbers = { 1, 6, 8, 98, 45, 65, 78656, 56 };
            var sonlar = numbers.Take(5);
            
            foreach(var number in sonlar)
            {
                Console.WriteLine(number);
            }
        }
        // "Extension metodlar"
        //5-misos

        //Skip operatori yordamida berilgan massivdan qanchadir elementn berilgan
        static void Linq5()
        {
            //massivning elon qilinishi
            int[] numbers = { 1, 6, 8, 98, 45, 65, 78656, 56 };
            //extension metod
            var sonlar = numbers.Skip(3);

            //natijani qaytarish uchun sikl
            foreach (var number in sonlar)
            {
                Console.WriteLine(number);
            }
        }
        static void Linq6()
        {
            string[] raqamToplami = { "a", "b", "d", "e", "f", "g", "h", "i", "j", "k", "l" };

            var teskariToplam = raqamToplami.Reverse();

            foreach (var num in teskariToplam)
            {
                Console.Write(num);
            }
        }
        static void Linq7()
        {
            int[] raqamToplami = { 1,5,6,9,15,8,4,57,59,65,56, };

            var teskariToplam = raqamToplami.TakeWhile(x => x < 65);

            foreach (var num in teskariToplam)
            {
                Console.Write(num);
            }
        }
    }
    }

