namespace basics.AsyncAwaitBasics;

public class AsyncAwaitBasics
{
    // * Avoid using async-void or Task Void combination, because if any error throws during this process, the error cannot be caught in the try/catch.
    public async Task Basics()
    {
        Console.WriteLine("Async Await Basics");

        // await keyword will freeup the thread and move the asyn code to waiting thread
        await AsyncOperationExample("https://jsonplaceholder.typicode.com/todos/1");
        
        // * These codes will not executed untill the Await resolves
        Console.WriteLine("Successfully completed the API call");

        await GetTodos();
        await GetTodo();

        var result = GetAgeAsync(10);
        Console.WriteLine("Get Age Async Result");
        Console.WriteLine(result.Result);

        await new AbortBasics().Basics();
    }

    // * Async Keyword determines that this is the Async Function
    // * There might be the chance that the thread can be released
    public async Task<string> AsyncOperationExample(string url)
    {
        try
        {
            Console.WriteLine("Fetching the Data Starts");
            // * In Realtime we should use IHttpClientFactory.
            // Short-lived 'HttpClient' is not recommended. Frequently creating 'HttpClient' instances can lead to socket exhaustion. Consider using 'IHttpClientFactory' or a long-lived (e.g., static) 'HttpClient' instance instead.
            var client = new HttpClient();

            string data = await client.GetStringAsync(url);
            Console.WriteLine($"Final Result {data}");
            return data;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Task<int> GetAgeAsync(int age) => Task.FromResult(age);

    // * Promise.All
    public async Task GetTodos()
    {
        var todo1 = AsyncOperationExample("https://jsonplaceholder.typicode.com/todos/2");
        var todo2 = AsyncOperationExample("https://jsonplaceholder.typicode.com/todos/3");
        
        // WhenAll is similar to promise.all
        // Parallely executes the API call, and returns the list of results in same order
        var result = await Task.WhenAll(todo1, todo2);
        
        Console.WriteLine("When ALl Result");
        Console.WriteLine(string.Join(", ", result));
    }

    public async Task GetTodo()
    {
        var todo1 = AsyncOperationExample("https://jsonplaceholder.typicode.com/todos/2");
        var todo2 = AsyncOperationExample("https://jsonplaceholder.typicode.com/todos/3");
        
        var result = await Task.WhenAny(todo1, todo2);
        
        Console.WriteLine("When Any Result");
        
        // * result.Result -> this also returns the data , but it will block the thread

        // * A better approch to handle the deadlock
        var data = await result;
        Console.WriteLine(data);
    }

    public async Task GetTodoWithConfigureWait()
    {
        // * Better and moder appoch to return the unwrapped values
        var todo1 = AsyncOperationExample("https://jsonplaceholder.typicode.com/todos/2").ConfigureAwait(false);

        var result = await todo1;
        
        Console.WriteLine($"When Any Result {result}");
    }
}