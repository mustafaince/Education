//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace DataSharing
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int number = 0;
//            var tasks = new List<Task>();
//            object locker = new object();
//            for (int i = 0; i < 15; i++)
//            {
//                tasks.Add(Task.Factory.StartNew(() =>
//                {
//                    for (int j = 0; j < 20; j++)
//                    {
//                        lock (locker)
//                        {
//                            number++;
//                        }
//                    }
//                }));
//                tasks.Add(Task.Factory.StartNew(() =>
//                {
//                    for (int j = 0; j < 20; j++)
//                    {
//                        lock (locker)
//                        {
//                            number--;
//                        }
//                    }
//                }));
//            }
//            Task.WaitAll(tasks.ToArray());
//            Console.WriteLine(number);
//            Console.ReadKey();
//        }
//    }
//}