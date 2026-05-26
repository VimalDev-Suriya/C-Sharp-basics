public class ListBasics
{
    public void Basics()
    {
        // * List are Ordered, indexed-based, allows-duplicates

        // * Can be initialzed like this by having some default values
        // var names = new List<string> {"suriya", "devaraj", "vimala", "keethana"};

        // Based on the return type , we can use "new()" directly into the String
        // List<string> names = new() {"a"};

        // * Simplest way to initialize the List in latest C#
        List<string> names = ["a", "b", "d", "e", "f"];

        Console.WriteLine(names[0]);

        names.Add("c"); // * It returns void
        names.Remove("c");

        var lastIndex = names.Count - 1;

        Console.WriteLine(names.Count);
        Console.WriteLine(names[lastIndex]);

        for(var i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i]);
            // if(names[i] == "b")
            // {
            //     break;
            // }
            // Console.Write(names[i], i);
        }

        int j = 0;
        do
        {
            Console.WriteLine(names[j]);
            j++;
        }while(j < names.Count);

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
    }
}