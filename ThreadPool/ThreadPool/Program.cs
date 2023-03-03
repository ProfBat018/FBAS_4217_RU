using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static CountdownEvent CountdownEvent = new CountdownEvent(10);
    static void Foo(object index)
    {
        object lockObject = new object();

        lock (lockObject)
        {

            Console.WriteLine($"IsThreadPool: {Thread.CurrentThread.IsThreadPoolThread}" +
                                $"\tIsManaged: {Thread.CurrentThread.ManagedThreadId}" +
                                $"\tIsBack: {Thread.CurrentThread.IsBackground}");
        }
    }

    //static void ThreadExample()
    //{
    //    for (int i = 0; i < 20; i++)
    //    {
    //        Thread thread = new Thread(Foo);
    //        thread.Start(i);
    //    }
    //}

    static void ThreadPoolExample()
    {
        var operation = 20;

        using (var countdown = new CountdownEvent(operation))
        {
            for (int i = 0; i < operation; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(param =>
                {
                    Console.WriteLine("Foo Started");

                    Foo(i);
                    countdown.Signal();
                }));
                Thread.Sleep(10);
            }
            countdown.Wait();
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();

        //stopwatch.Start();
        //ThreadExample();
        //stopwatch.Stop();

        //var a = stopwatch.Elapsed;
        //stopwatch.Reset();

        stopwatch.Start();
        ThreadPoolExample();
        stopwatch.Stop();
        var b = stopwatch.Elapsed;
        stopwatch.Reset();

        Thread.Sleep(10);
        //Console.WriteLine(a);
        Console.WriteLine(b);
    }

}

#region ThreadVsThreadPool


//Thread th1 = new(() => Console.WriteLine(Thread.CurrentThread.IsBackground));
//th1.Start();


//using CountdownEvent countdown = new(1);
//ThreadPool.QueueUserWorkItem(new WaitCallback(param =>
//{
//    Console.WriteLine("Started");
//    Console.WriteLine(Thread.CurrentThread.IsBackground);
//    Console.WriteLine("Ended");
//    countdown.Signal();
//}));
//countdown.Wait();

#endregion

#region ListOfThreads

//ProcessThreadCollection threadCollection = Process.GetCurrentProcess().Threads;


//Console.WriteLine($"Number of threads: {threadCollection.Count}");


//foreach (ProcessThread item in threadCollection)
//{
//    Console.WriteLine($"ID: {item.Id}\t {item.ThreadState}");
//}
#endregion
