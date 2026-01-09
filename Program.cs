using TaskFromScratch;

Console.WriteLine($"Starting thread Id: {Environment.CurrentManagedThreadId}");

MyTask task = MyTask.Run(() =>
{
    Console.WriteLine($"First custom task thread Id: {Environment.CurrentManagedThreadId}");
});

task.ContinueWith(() =>
{
    MyTask.Run(() =>
    {
        Console.WriteLine($"Third custom task thread Id: {Environment.CurrentManagedThreadId}");
    });
    Console.WriteLine($"Second custom task thread Id: {Environment.CurrentManagedThreadId}");
});

Console.ReadLine();