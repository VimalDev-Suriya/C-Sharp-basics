namespace basics.OOPS;

// * Here we use ":" to inherit from Parent class
public class EmployeeInheritance : Person
{
    private string _department;

    // * To pass the data from child class to parent class.
    public EmployeeInheritance(string name, int age, string dept) : base(name, age)
    {
        _department = dept;
    }

    // * To override the method present in Parent class, we should use override and make sure that the parent class method has virtual keyword in the correspodning method
    // * I can use directly like below, C# complier will not throw any error
    // Underthehood, it will hide the implementation of Parent class implementation
    // public string Describe()
    // {
    //     return "";
    // }

    // * Using override will override the implementation of the Parent class
    // * To access the properties from the base class, we can use base keyword
    public override string Describe()
    {
        Console.WriteLine($"{base.testProtectedProperties}");
        return $"I am {base.Name}, aged {base.Age} and Working as {_department}";
    }

    public sealed override void SealedMethod()
    {
        Console.WriteLine("The Child Class SealedMethod, which cannot be overrided further by any derived class");
    }
}