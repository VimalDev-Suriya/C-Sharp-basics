using System.Text;

namespace basics.StringsBasics;

public class StringsBasics
{
    public void StringsDemo()
    {
        // Strings are immutable, They are actually stored in heap and use reference. But it feels like we can use them as values.
        // * Below code can create 3 different set of String objects
        string name = "Hi";
        name += " Suriya";
        name += " Hello!!";

        Console.WriteLine(name);

        // * String Builder is the class, efficient to perform some concatenation operations.
        StringBuilder myName = new StringBuilder("Hello");
        Console.WriteLine(myName);
        myName.Append(" World"); // Concatenation - This will have modify the existing data, wont create a new object
        Console.WriteLine(myName);
        
        // * String Interpolation -> $""
        Console.WriteLine($"String = {name} and StringBuilder = {myName}");
        
        // * Basic String Operations
        Console.WriteLine("hello".ToUpper()); // HELLO -> we have `toLower` also
        // Trim, TrimEnd, TrimStart
        Console.WriteLine("    hello   ".Trim()); // Removes trailing spaces
        Console.WriteLine("test".Split(',')); // accept the char and return the String []
        Console.WriteLine("test2".Contains('2')); // Returns bool
        Console.WriteLine("hellooo".Replace('l', 'r')); // herroo
        Console.WriteLine("hello".Length); // 5
        Console.WriteLine("hello".Substring(0, 3)); // hel 
    }

}