using TaskFromScratch;

Console.WriteLine($"Starting thread Id: {Environment.CurrentManagedThreadId}");

MyTask.Run(() => Console.WriteLine($"First custom task thread Id: {Environment.CurrentManagedThreadId}")).Wait();

MyTask.Delay(TimeSpan.FromSeconds(1)).Wait();

Console.WriteLine($"Second custom task thread Id: {Environment.CurrentManagedThreadId}");

MyTask.Delay(TimeSpan.FromSeconds(1)).Wait();

MyTask.Run(() => Console.WriteLine($"Third custom task thread Id: {Environment.CurrentManagedThreadId}")).Wait();