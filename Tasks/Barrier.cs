//using System;
//using System.Threading;
//using System.Threading.Tasks;

//namespace BarrierExample
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Barrier barrier = new Barrier(2, (b) =>
//            {
//                // Bu barrier constructorına yaptığımız tanımlama ile her bir faz 2 adımdan oluşacak. Ve her bir faz sonunda, bu callback çalışıp aşağıdaki çıktıyı terminale yazacak.
//                Console.WriteLine("Phase {0} completed.", b.CurrentPhaseNumber);
//            });
//            var fastTask = Task.Run(() =>
//            {
//                Console.WriteLine("fastTask is doing something...");
//                Thread.Sleep(1);
//                // Hangi taskin önce çalışacağını bilemesek te bekleme süresi az olduğu için ilk önce aşağıdaki satırın çalışacağını biliyoruz.
//                // barier.SignalAndWait() methodu bir adımın tamamlandığını bildirir.
//                // Eğer tamamlanan adım sayısı belirlenen adım sayısına ulaşmadıysa bu satırın altındaki kodlar çalışmak için bütün adımların tamamlanmasını bekleyecek.
//                barrier.SignalAndWait();
//                Console.WriteLine("fastTask is done");
//            });

//            var longRunningTask = Task.Run(() =>
//            {
//                Console.WriteLine("longRunningTask is doing something...");
//                Thread.Sleep(2000);
//                Console.WriteLine("longRunningTask is done");
//                barrier.SignalAndWait();
//            });

//            Task.WhenAll(new[] { longRunningTask, fastTask }).Wait();
//            Console.WriteLine("Done...");
//            Console.ReadKey();
//        }
//    }
//}