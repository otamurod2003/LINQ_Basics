using System.Xml.Serialization;

namespace _01_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq1();
            Linq2();
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
            strings.Add("acc");
            strings.Add("acayy");
            strings.Add("adassa");
            strings.Add("asswswe");
            strings.Add("addsdf");
            strings.Add("assdeededg");                
            strings.Add("h");
            strings.Add("i");
            strings.Add("i");

            var stringSort = from str in strings
                             
                             orderby str.StartsWith("a")
                             select str;


            foreach (var item in str)
            {

            }

                            
        }
    }
    }

