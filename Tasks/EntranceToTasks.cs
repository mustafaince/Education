//using System;
//using System.Threading.Tasks;

////https://ilkererhalim.medium.com/

//namespace CreatingAndStartingTask
//{
//    class Program
//    {
//        static void DoWork(string message)
//        {
//            for (int i = 0; i < 1000; i++)
//            {
//                Console.Write(message);
//            }
//        }

//        static void Main(string[] args)
//        {
//            Task.Factory.StartNew(() =>
//            {
//                DoWork("T1");
//                Console.WriteLine("DoWork Completed for T1");
//            });

//            var task = new Task(() =>
//            {
//                DoWork("T2");
//                Console.WriteLine("DoWork Completed for T2");
//            });

//            Console.WriteLine("Main Thread Log 1");
//            task.Start();
//            Console.WriteLine("Main Thread Log 2");
//            Console.ReadKey();
//        }
//    }
//}