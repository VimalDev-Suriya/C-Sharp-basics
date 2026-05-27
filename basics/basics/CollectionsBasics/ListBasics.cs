public class ListBasics
{
    public void Basics()
    {
        // * List are Ordered, indexed-based, allows-duplicates

        // * Can be initialzed like this by having some default values
        // This is Object initializer syntax
        // var names = new List<string> {"suriya", "devaraj", "vimala", "keethana"};

        // Based on the return type , we can use "new()" directly into the String
        // List<string> names = new() {"a"};

        // * This will create the empty list with 10 size.
        // List<string> test = new List<string>(10);

        // * Initializing the List with 10 size and 2 values in it.
        // List<string> test_1 = new List<string>(10)
        // {
        //     "a", "b"
        // };

        // * Simplest way to initialize the List in latest C# version
        List<string> names = ["a", "b", "d", "e", "f"];

        Console.WriteLine(names[0]);

        names.Add("c"); // * It returns void
        names.Remove("c");

        var lastIndex = names.Count - 1;

        Console.WriteLine(names.Count);
        Console.WriteLine(names[lastIndex]);


        // * Contains helps to determine whether the element present in the LIST
        if (names.Contains("a"))
        {
            Console.WriteLine("Collection has the value a");
        }
        else
        {
            Console.WriteLine("Not Found");
        }

        // * Add range -> Inserting Element into the Spcific Index
        names.Insert(2, "Hello");
        Console.WriteLine($"List contains {names[2]}");

        // * Different ways to iterate over the LIST
        for(var i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i]);
        }

        int j = 0;
        do
        {
            Console.WriteLine(names[j]);
            j++;
        }while(j < names.Count);

        // * foreach accepts only the IEnumerable types
        // LIST, DICTIONERY (as of now)
        foreach(var item in names)
        {
            Console.WriteLine(item);
        }

        // * List Methods
        // * ForEach helps to loop over the items
        names.ForEach(name => Console.WriteLine(name));
    }
}