using System.Runtime.CompilerServices;

namespace TaskFromScratch;
public readonly struct MyTaskAwaiter : INotifyCompletion
{
    private readonly MyTask _task;
    internal MyTaskAwaiter(MyTask task) => _task = task;
    public bool IsCompleted => _task.IsCompleted;
    public void OnCompleted(Action continuation) => _task.ContinueWith(continuation);
    public MyTaskAwaiter GetAwaiter() => this;
    public void GetResult() => _task.Wait();
}