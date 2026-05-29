namespace basics.Delegates;

// * By default when using += / -= we cannot be able to pass the data from one delegate function to another
// * But we can use LINQ's Aggregate or Using "this" keyword.
public class AggregateBasics
{
    public void Basics()
    {
        Console.WriteLine("Delegates Aggregate Basics");
        AggregateBasics_1();
        AggregateBasics_2();
    }
    
    // * Using LINQ Aggregate
    public void AggregateBasics_1()
    {
        Func<int, int> mul_2 =  x => x * 2;
        Func<int, int> addNum = x => x + 20;
        Func<int, int> mul_10 = x => x * 10;
        
        // 5 => 10 => 30 => 300
        Func<int, int>[] pipeline = { mul_2, addNum, mul_10 };

        int initialValue = 5;
        
        var result =  pipeline.Aggregate(initialValue, (value, cb) => cb(value));
        
        Console.WriteLine(result);
    }

    public void AggregateBasics_2()
    {
        Func<int, int> mul_2 =  x => x * 2;
        Func<int, int> addNum = x => x + 20;
        Func<int, int> mul_10 = x => x * 10;
        
        int initialValue = 5;

        var result = mul_2.Chain(addNum).Chain(mul_10);
        Console.WriteLine(result(initialValue));
    }
}

// * Cleaner approch
public static class FunctionExtensions
{
    public static Func<T,T> Chain<T>(this Func<T, T> first, Func<T, T> second)
    {
        return input => second(first(input));
    }
}