//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace CreatingAndStartingTask
//{
//    class Program
//    {
//        static int count = 0;
//        public static int Sum(IEnumerable<int> source)
//        {
//            int sum = 0;
//            foreach (var item in source)
//            {
//                sum += item;
//                count++;
//            }
//            return sum;
//        }

//        static void Main(string[] args)
//        {
//            var firstCollection = Enumerable.Range(1, 7000);
//            var secondCollection = Enumerable.Range(7000, 14000);
//            var thirdCollection = Enumerable.Range(14000, 21000);
//            // StartNew methodu int tipi ile çalıştığında method içerideki action' ın geriye integer bir değer dönmesini bekler.
//            var task1 = Task.Factory.StartNew<int>(() =>
//            {
//                Console.WriteLine("firstCollectinon calculating on Task {0}", Task.CurrentId);
//                return Sum(firstCollection);
//            });
//            // Action geriye zaten bir integer değer döndürdüğü için int tipini tanımlamak zorunda değiliz.
//            var task2 = Task.Factory.StartNew(() =>
//            {
//                Console.WriteLine("secondCollection calculating on Task {0}", Task.CurrentId);
//                return Sum(secondCollection);
//            });
//            // Lambda ile methodları aşağıdaki gibi çalıştırıp sonucunu alabiliriz.
//            var task3 = Task.Factory.StartNew(() => Sum(thirdCollection));

//            Console.WriteLine("Sum of firstCollection:{0} , {1}", task1.Result, count);
//            Console.WriteLine("Sum of secondCollection:{0} , {1}", task2.Result, count);
//            Console.WriteLine("Sum of thirdCollection:{0} , {1}", task3.Result, count);
//            Console.WriteLine("Sum of Collections:{0} , {1}", task1.Result + task2.Result + task3.Result, count);
//            Console.ReadKey();
//        }
//    }
//}