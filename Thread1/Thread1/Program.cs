
// Default thread delegates;
// ThreadStart
// ParameterizedThreadStart


// Thread - класс,
// который запускает нашу функцию в отдельном потоке

#region CpuBound

//Console.WriteLine("Begin");
//int res = 0;
//for (int i = 0; i < 2000000000; i++)
//{
//    res += i;
//}
//Console.WriteLine("End");

#endregion

#region I/Obound

/*Console.WriteLine("Begin");
for (int i = 0; i < 5; i++)
{
    string name = Console.ReadLine();
    Console.WriteLine(name);
}
Console.WriteLine("End");*/

#endregion

#region Thread

using System.Diagnostics;

void foo()
{
    Console.WriteLine($"Foo priority: {Thread.CurrentThread.ManagedThreadId}");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"From thread{i}");
    }
}

Thread th1 = new Thread(foo);
th1.Start();

    Console.WriteLine($"Main priority: {Thread.CurrentThread.ManagedThreadId}");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"From main{i}");
}


foreach (ProcessThread item in Process.GetCurrentProcess().Threads)
{
    Console.WriteLine($"{item.CurrentPriority}\t{item.ThreadState}");
}

#endregion

