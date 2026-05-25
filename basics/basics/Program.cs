// * To import additional packages, we use "using"
using System.Text;

namespace basics;

class Program
{
    static void Main(string[] args)
    {
        // VariableBasics();
        // StringBasics();
        TypeCastingBasics();
        MethodsBasics();
        
        // * Boxing and Unboxing
        // BoxingDemo boxingDemo = new BoxingDemo();
        // boxingDemo.Main();
        
        // * OOPS
    }

    static void VariableBasics()
    {
        // * Variable Declaration
        string name;

        // * Variable Initialization
        name = "Suriya";
        Console.WriteLine(name);

        int a = 10; // * 32 bit
        long b = 10; // * 64 bit

        string e = "name";

        bool f = false;

        char g = '1';
        
        // * Floating
        double d = 10.2; // * 64 bit
        decimal c = 10.1m; // 128 bit - more accuracy

        // // * C# does not provide the implicit null value assignment.
        // a = null; // this will throw error
        
        // * var - infered as the corresponding data type in compile time
        var myName = "name";
        // myName = 10; //This is not possible because, the variable was already initialized with string
        
        // * Nullable values
        // "?" tells the complire that this variable can be null in future.
        int? nullableNum = 10;
        nullableNum = null;

        //
        if (nullableNum.HasValue)
        {
            Console.WriteLine("Its not null");
        }
        
        // Null coalescing
        // * To use ??, the operands should be nullable. If not we cannot use them
        var dynamicValue = nullableNum ?? 0;
    }
    
    static void StringBasics()
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

    static void TypeCastingBasics()
    {
        // * Converting one data type to another
        
        // * Implicit (Widening of data types)
        // int < long/double < decimal
        int a = 10;
        long b = a;
        Console.WriteLine(b.GetType()); // System.Int64 is the long

        // int to double
        double  d = a;
        Console.WriteLine(d.GetType()); // System.Double
        
        // Int to Decimal
        decimal c = a;
        Console.WriteLine(c.GetType()); // System.Decimal
        
        // long to decimal
        decimal e = b;
        Console.WriteLine(e.GetType());

        // long f = c; // This will throw the error because decimal is greter that long
        // long f = d; // This will throw error because both long and decimal are 64bit
        
        // * Explicit convertion
        // Always be aware of explicit type convertion as they may result in data loss
        // in below example 3.14 resolved to 3
        double pi = 3.14;
        int intPI = (int) pi; 
        
        Console.WriteLine(intPI.GetType()); // Int32
        Console.WriteLine(intPI); // 3
        
        // * We can use Convert Class for type casting
        int newPI = Convert.ToInt32(intPI); 
        Console.WriteLine(newPI.GetType());
        
        // * SImilar to getSafe utility
        int.TryParse("q", out int newPIInt);
        Console.WriteLine(newPIInt); // return 0 if there was a error
    }

    // * Here the Ref is the memory, So whatever changes in the memory, it will be reflected back to its usage
    static void PassByRef(ref int? x)
    {
        x = x * x;
    }

    // * Here the "param" is the key word, similar to args or ...params syntax in JS
    static int Sum(params int[] numbers)
    {
        return numbers.Sum();
    }

    static void CalculateRectangle(int length, int breadth, out int area, out int perimeter)
    {
        // * Here this function need to explicitly assign the value to the "area" and "perimeter" params.
        // Also the "area" and "perimeter" are not exact params, they are the one which returned from the function itself
        
        // If we are not intializing these values, then compiler will through error.
        area = length * breadth;
        perimeter = area * 2;
    }

    static void MethodsBasics()
    {
        int? x = 10;
        
        PassByRef(ref x);
        
        // Without using ref, the value will be 10
        // With using ref, the value will be 100
        // Here the variable X's value was mutated, because we passed them as ref, instead of value.
        Console.WriteLine($"The value of X is = {x}"); 
        
        // * Params - getting spread params in function
        int result = Sum(1, 2, 3, 4, 5);
        Console.WriteLine(result);

        // * Here I never initialized the area & perimeter
        CalculateRectangle(10, 20, out int area, out int perimeter);
        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }
}