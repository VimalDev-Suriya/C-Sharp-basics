namespace basics.OOPS;

// * Basics of Class
// By Default all the Classes are Internal, so we should explicitly set to Public
// If the constructor is private, we cannot be able to create the instance
public class Person
{
    private string _name;
    private int _age;
    
    // * It will be executed only during new Person()
    public Person()
    {
        Console.WriteLine("Default Constructor Executed");
    }
    
    public Person(string name, int age)
    {
        _name = name;
        _age = age;
        Console.WriteLine($"Named Constructor Executed with {name} {age}");
    }

    // * Control comes to below constructor, when it sees the "this", then the control goes back to the corresponding constructor (i.e) above one
    // Post executing the above constructor, the below constructor will be executed.
    public Person(string name) : this(name, 0)
    {
        Console.WriteLine("Constructor Executed with This Keyword");
    }
}

// public class Person
// {
//     private string _name;
//     
//     // * It will be executed only during new Person()
//     public string Name
//     {
//         get => _name;
//         set => _name = value;
//     }
//
//     public int Age
//     {
//         get;
//         set;
//     }
// }