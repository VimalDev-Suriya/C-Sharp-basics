using System.Collections; // for ArrayList

namespace basics;

public class BoxingDemo
{
    // * This is the process where the value types like char, int, bool enum, struct can be stored in Heap (Object types) i.e reference types
    // in shot converting value types to primitive types
    
    // Its mainly used in a place where we need to store the multiple non-generic types into single collection.
    // ArrayList is example where all the data stored in here are stored as Object types
    public void Main()
    {
        Console.WriteLine("Boxing and Unboxing in C#");

        // Boxing (converting from value types to reference types)
        int i = 10;
        object o = i; // This is called boxing - where the type was changed from int type to System.Object type.
        
        // * UnBoxing (type conversion from inject to value types)
        int a = (int)o;
        Console.WriteLine(a.GetType()); // int
        
        ArrayList arrayList = new ArrayList();
        
        // * Here I can use multiple data types
        // All the type of data will be stored as Object types
        arrayList.Add(1);
        arrayList.Add('a');
        arrayList.Add("Name");
        arrayList.Add(true);

        var val = arrayList[0]; // indexed base access
        arrayList.Remove(true);
        Console.WriteLine(arrayList[3]);

        // CONS
        // While useful, boxing carries a performance cost because it involves heap allocation and eventual garbage collection.
        // Modern C# development often avoids unnecessary boxing (ArrayList) by using Generics (like List<int> instead of ArrayList), which keep value types on the stack
    }
}