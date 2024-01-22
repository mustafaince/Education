using System;
using System.Threading.Tasks;

namespace ContinueWithExample
{
    class Program
    {
        //ContinueWith
        //static void Main(string[] args)
        //{
        //    var task1 = Task.Run(() => {
        //        Console.WriteLine("Task 1 running");
        //        return "Task 1 result";
        //    });
        //    var task2 = task1.ContinueWith((completedTask) => {
        //        Console.WriteLine("Task 1 completed, the result is:{0}", completedTask.Result);
        //    });
        //    // task2 nin başlaması için task1 in tamamlanması gerekiyor, bu yüzden task2 nin tamamlanmasını beklemek yeterli.
        //    task2.Wait();
        //    Console.ReadKey();
        //}

        //ContinueWhenAll
        //static void Main(string[] args)
        //{
        //    var task1 = Task.Run(() =>
        //    {
        //        Console.WriteLine("Task 1 running");
        //        return "Task 1 result";
        //    });
        //    var task2 = Task.Run(() =>
        //    {
        //        Console.WriteLine("Task 2 running");
        //        return "Task 2 result";
        //    });
        //    var task3 = Task.Factory.ContinueWhenAll(new Task<string>[] { task1, task2 }, (taskList) =>
        //    {
        //        foreach (var task in taskList)
        //        {
        //            Console.WriteLine(task.Result);
        //        }
        //    });
        //    task3.Wait();
        //    Console.ReadKey();
        //}

        //TaskContinuationOptions
        //static void Main(string[] args)
        //{
        //    var task1 = Task.Run(() =>
        //    {
        //        Console.WriteLine("Task 1 running.");
        //        Random rnd = new Random();
        //        if (rnd.Next(10) % 2 == 0)
        //        {
        //            throw new Exception("Something went wrong.");
        //        }
        //        return "Task 1 result";
        //    });
        //    // Bu task yalnızca task1 başarılı bir şekilde tamamlanırsa çalışacak.
        //    var successHandler = task1.ContinueWith((completedTask) =>
        //    {
        //        Console.WriteLine("Task 1 completed, result is: {0}", completedTask.Result);
        //    }, TaskContinuationOptions.OnlyOnRanToCompletion);
        //    // Bu task yalnızca task1 hata verirse tamamlanacak.
        //    var failHandler = task1.ContinueWith((failedTask) =>
        //    {
        //        Console.WriteLine("Task 1 failed. Status: {0}", task1.Status);
        //    }, TaskContinuationOptions.OnlyOnFaulted);
        //    try
        //    {
        //        // Bir task continuationOption parametresi yüzünden tamamlanmazsa Status propertysi Canceled olarak set edilir ve buda WaitHandler Task cancel edildiği için exception fırlatır.
        //        Task.WhenAll(new[] { successHandler, failHandler }).Wait();
        //    }
        //    catch (AggregateException ex)
        //    {
        //        ex.Handle(e => true);
        //    }
        //    Console.WriteLine("task1 status: {0}", task1.Status);
        //    Console.WriteLine("successHandler status: {0}", successHandler.Status);
        //    Console.WriteLine("failHandle status: {0}", failHandler.Status);
        //    Console.ReadKey();
        //}
    }
}