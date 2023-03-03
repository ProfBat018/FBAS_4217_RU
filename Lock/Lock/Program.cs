// lock

#region Lesson1
/*
void foo()
{
    object lockObject = new object();
    lock (lockObject) // Lock - синактический сахар...
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(i);
        }
    }
}


for (int i = 0; i < 3; i++)
{
    Thread t = new(foo);
    t.Start();
    Thread.Sleep(1000);
}

*/
#endregion

#region Lesson2

/*
 class ThreadTest
{
    static bool _done = false;
    static void Go(object a)
    {
        if (!_done)
        {
            _done = true;
            Console.WriteLine($"Done {a}");
        }
    }

    static void Main()
    {
        Thread t1 = new(new ParameterizedThreadStart(Go));
        t1.Start("From Thread");
    
        Go("From Main");
    }
   
}
*/

/*
 class ThreadSafe
{
    //static bool _done;
    

    static readonly object _locker = new object();
    static int _threadCount = 0;
    
    static void Go(object obj)
    {
        lock (_locker)
        {
            _threadCount++;
             Console.WriteLine($"Done {obj}, count: {_threadCount}");  
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(new ParameterizedThreadStart(Go));
        t1.Start("From thread");
        Go("from main");
    }
   
}

*/

#endregion

// StaThread 

// COM port 




float add(float num1, float num2)
{
    return num1 + num2;
}


float result = add(1.2, 2.8);

Console.WriteLine(result);


