namespace basics.AsyncAwaitBasics;

// * We can create the Custom Task, like new Promise in JS
public class PromiseInCSharp
{
    // In C#, TaskCompletionSource<T> allows you to manually control the lifecycle of a Task, matching how a Promise constructor works in JavaScript.

    public Task<int> Basics()
    {
        TaskCompletionSource<int> tcs = new TaskCompletionSource<int>();

        bool isSuccess = true;

        if (isSuccess)
        {
            tcs.SetResult(42); // Equivalent to resolve()
        }
        else
        {
            tcs.SetException(new Exception("Failed")); // Equivalent to reject()
        }

        return tcs.Task;
    }
}