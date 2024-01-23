using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelLoop
{
    //ParallelLoopVsSyncLoop
    //class Program
    //{
    //    static long SyncLoop()
    //    {
    //        Stopwatch stopWatch = new Stopwatch();
    //        stopWatch.Start();
    //        for (int i = 0; i < 90000; i++)
    //        {
    //            // Döngü içerisinde 10 iterasyonluk bir bekleme yapıyoruz.
    //            Thread.SpinWait(10);
    //        }
    //        stopWatch.Stop();
    //        return stopWatch.ElapsedMilliseconds;
    //    }

    //    static long ParallelLoop()
    //    {
    //        Stopwatch stopWatch = new Stopwatch();
    //        stopWatch.Start();
    //        Parallel.For(0, 90000, (i) =>
    //        {
    //            Thread.SpinWait(10);
    //        });
    //        stopWatch.Stop();
    //        return stopWatch.ElapsedMilliseconds;
    //    }
    //    static void Main(string[] args)
    //    {
    //        var syncLoopMs = SyncLoop();
    //        var parralelLoopMs = ParallelLoop();
    //        Console.WriteLine("Syncloop ms :{0}", syncLoopMs);
    //        Console.WriteLine("Parallel loop ms: {0}", parralelLoopMs);
    //        Console.ReadKey();
    //    }

    //}

    //ParallelLoopBreakAndStop
    //stop: Döngüyü en kısa sürede sonlandırır.
    //break: Kendinden sonra çalışacak olan iterasyonları en kısa süre içerisinde sonlandırır.
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Loop1");
    //        var loopResult1 = Parallel.For(0, 10, (i) =>
    //        {
    //            Console.WriteLine(i);
    //        });

    //        Console.WriteLine("Loop2");
    //        var loopResult2 = Parallel.For(0, 20, (i, state) =>
    //        {
    //            if (i == 1)
    //            {
    //                state.Break();
    //            }
    //            Console.WriteLine(i);
    //        });
    //        Console.WriteLine("Loop3");
    //        var loopResult3 = Parallel.For(0, 20, (i, state) =>
    //        {
    //            if (i == 1)
    //            {
    //                state.Stop();
    //            }
    //            Console.WriteLine(i);
    //        });
    //        Console.WriteLine("Loop result 1: IsCompleted:{0}, LowestBreakIteration:{1}", loopResult1.IsCompleted, loopResult1.LowestBreakIteration);
    //        Console.WriteLine("Loop result 2: IsCompleted: {0}, LowestBreakIteration:{1}", loopResult2.IsCompleted, loopResult2.LowestBreakIteration);
    //        Console.WriteLine("Loop result 3: IsCompleted:{0}, LowestBreakIteration:{1}", loopResult3.IsCompleted, loopResult3.LowestBreakIteration);
    //        Console.ReadKey();
    //    }
    //}

    //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //ParallelQuery<string> items = numbers.AsParallel().Select(number => $”Item -{number}”);
    //foreach (var item in items)
    //{
    //    Console.WriteLine(item);
    //}
    //Console.ReadKey();

    //class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //            var filtered = numbers.AsParallel().AsOrdered().Where((number) =>
    //            {
    //                Console.WriteLine("Current Number:{0}", number);
    //                return number > 5;
    //            });
    //            Console.WriteLine("Before GetEnumarator.");
    //            // ToList metodu GetEnumerator metodunu çalıştırır.
    //            // Bkz: https://github.com/microsoft/referencesource/blob/master/System.Core/System/Linq/ParallelEnumerable.cs (Satır: 4907,4918,4922)
    //            // Bkz: https://referencesource.microsoft.com/#mscorlib/system/collections/generic/list.cs,61f6a8d9f0c40f6e (Satır: 98)
    //            List<int> filteredList = filtered.ToList();
    //            Console.WriteLine("After GetEnumarator.");
    //            Console.ReadKey();
    //        }
    //    }
}