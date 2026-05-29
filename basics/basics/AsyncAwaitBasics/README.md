# Async And Await in C#

![img.png](img.png)

TASK <----> Promise

C# is the `Multi-threaded language`. Unlike in JS the eventloop validates the callstack and browser/nodejs threads  so we will get the output, even if we just call the API call.

But C# will never validate the pending I/O operations, once it executes all sync codes it will exit the process. Which is why we can't able to get the solution, if we directly call the Async operation

```csharp
 Console.WriteLine("ASYNC STARTS (PROGRAM FILE)");
 var asyncBasics = new AsyncAwaitBasics.AsyncAwaitBasics();

 // C# is the Multi threaded Language.
 asyncBasics.Basics();
 Console.WriteLine("ASYNC AFTER CALL (PROGRAM FILE)");
```

- Unless we add await / ReadLine we will not see output of the API call.
- Await seems like sync but underthehood the code was moved to another thread

## Task-based Asynchronous Pattern:

Using both of `Task` and `Async` keywords help us to implement the TAP pattern

- **Task** - Since c# is the static typed language, we should ensure its return type, But for async operations we are not guranteed. So for the placeholder of the eventual results we use Task in here.
- **Async** - A keyword that helps to make the Compiler to use the `await` keyword to get the results. 
  - In also prepares the method to handle the pause and resume of operations.

### Flow of Async code:
1. await is hit — the compiler saves the method state (like a bookmark)
2. The current thread is released back to the thread pool
3. The awaited operation runs (I/O, network, disk)
4. When done, a thread pool thread picks up the method from the bookmark
5. Execution continues after the await line

- Whenever we want to get the final value from the `Task`, we can use `await` to get the result.