using TaskFromScratch;

Console.WriteLine($"Current thread Id: {Thread.CurrentThread.ManagedThreadId}");

MyTask.Run(() => Console.WriteLine($"Current thread Id: {Thread.CurrentThread.ManagedThreadId}"));

Console.ReadLine();