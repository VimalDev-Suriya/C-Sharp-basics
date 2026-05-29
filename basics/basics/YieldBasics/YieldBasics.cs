namespace basics.YieldBasics;

public class YieldBasics
{
    // * SImilar to JS we have Yield in C# also
    // These functions will not executed, unless the callback was called

    public IEnumerable<int> GetNumbers()
    {
        int count = 0;
        while (true)
        {
            count = count + 1;
            
            if(count == 10) yield break;
            
            yield return count;
        }
    }

    public void Basics()
    {
        Console.WriteLine("Yeild Basics");
        var count = GetNumbers().GetEnumerator();
        
        // * Enumerators consist of feilds
        // * Current -> holds the value
        // * MoveNext -> helps to move forward
        Console.WriteLine(count.Current);

        count.MoveNext();
        Console.WriteLine(count.Current);
        count.MoveNext();
        Console.WriteLine(count.Current);
        count.MoveNext();
        Console.WriteLine(count.Current);
        
        var first6 = GetNumbers().Take(6);

        foreach (var data in GetNumbers())
        {
            Console.WriteLine(data);
        }
    }
}