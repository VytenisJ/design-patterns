//SingleThreadSingleton();
MultithreadSingleton();

void SingleThreadSingleton()
{
    Console.WriteLine("Thread-unsafe singleton: single thread");

    var singleton1 = Singleton.SingleThreadSingleton.Instance;
    Console.WriteLine($"Instance (1): {singleton1.Identifier}");

    var singleton2 = Singleton.SingleThreadSingleton.Instance;
    Console.WriteLine($"Instance (2): {singleton2.Identifier}");   
}

void MultithreadSingleton()
{
    Console.WriteLine("Thread-unsafe singleton: multi thread");

    var tasks = new List<Task>();

    var task1 = Task.Run(() =>
    {
        var singleton = Singleton.SingleThreadSingleton.Instance;
        Console.WriteLine($"Instance (1): {singleton.Identifier}");
    });
    tasks.Add(task1);

    var task2 = Task.Run(() =>
    {
        var singleton = Singleton.SingleThreadSingleton.Instance;
        Console.WriteLine($"Instance (2): {singleton.Identifier}");
    });
    tasks.Add(task2);

    Task.WhenAll(tasks).Wait();
}