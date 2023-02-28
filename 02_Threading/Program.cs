using System.Threading;
namespace _02_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Misol 1
            //Thread t = new Thread(WriteY);
            //t.Name = "test";
            //t.Start();
            //for (int j = 0; j < 1000; j++)
            //{
            //    Console.Write("Y");
            //}
            #endregion
            #region Misol 2
            //Thread thread2 = new Thread(Go);
            //thread2.Start();
            //Console.WriteLine("thread 2 oqimi boshlandi ");
            ////thread2.Join();
            //Console.WriteLine(thread2.Join(10));
            //Console.WriteLine("thread 2 oqimi tugadi");
            #endregion
            #region Misol 3
            Console.WriteLine("Oqim 3 soniyali tanaffus oladi");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine("Oqim 500 millisekundga tanaffus oladi...");
            Thread.Sleep(500);
            #endregion
        }

        private static void WriteY()
        {
            Console.WriteLine("Threading ishga tushdi");
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("X");
            }
        }
        private static void Go()
        {
            for (int k = 0; k < 1000; k++)
            {
                Console.Write("b");
            }
        }
    }
}