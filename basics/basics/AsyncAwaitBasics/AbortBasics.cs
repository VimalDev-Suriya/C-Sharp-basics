namespace basics.AsyncAwaitBasics;

public class AbortBasics
{
    public async Task Basics()
    {
        var cts = new CancellationTokenSource();

        try
        {
            cts.CancelAfter(TimeSpan.FromSeconds(5));
            
            // * Passing the token/Signal
            await DoSomeAsync(cts.Token);
        }
        catch (Exception e)
        {
            Console.WriteLine("Excaption after 5 seconds");
            Console.WriteLine(e);
        }
        finally
        {
            // Cleaning the token for individual Tasks
            cts.Dispose();
        }
    }

    public async Task DoSomeAsync(CancellationToken ct)
    {
        for (var i = 0; i < 100; i++)
        {
            // Throwing the error, if token want to be cancelled
            ct.ThrowIfCancellationRequested();
            
            await Task.Delay(100, ct);
            Console.WriteLine($"{i} after 500 seconds");
        }
    }
}