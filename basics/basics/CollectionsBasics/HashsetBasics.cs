public class HashsetBasics
{
    public void Basics()
    {
        Console.WriteLine("HashSet Starts");
        // * Empty Hashset initialization
        // HashSet<int> ints = new();

        // * Initializing the Hashset with initial Values
        HashSet<int> ints = new HashSet<int>{1, 2, 3};

        // * Returns boolean, determine whether the element was successfully pushed.
        // * If we add the duplicate data, then it will return false.
        var isAdded = ints.Add(10);
        Console.WriteLine($"Item 10 was added {isAdded}");

        ints.Remove(1);

        // This is O(1) in average case
        if (ints.Contains(1))
        {
            Console.WriteLine("There is 1");
        }
        else
        {
            Console.WriteLine("There is No 1");
        }

        // * We can use foreach for looping the items
        foreach(var item in ints)
        {
            Console.WriteLine(item);
        }
    }
}