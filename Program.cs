using TaskFromScratch;

Console.WriteLine($"Starting thread Id: {Environment.CurrentManagedThreadId}");

await MyTask.Run(() => Console.WriteLine($"First custom task thread Id: {Environment.CurrentManagedThreadId}"));

await MyTask.Delay(TimeSpan.FromSeconds(1));

Console.WriteLine($"Second custom task thread Id: {Environment.CurrentManagedThreadId}");

await MyTask.Delay(TimeSpan.FromSeconds(1));

await MyTask.Run(() => Console.WriteLine($"Third custom task thread Id: {Environment.CurrentManagedThreadId}"));