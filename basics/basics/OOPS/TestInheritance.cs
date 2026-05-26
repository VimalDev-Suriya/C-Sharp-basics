using basics.OOPS;

// Multilevel Inheritance is possible in C#
public sealed class TestInheritance : EmployeeInheritance
{
    public TestInheritance(string name, int age, string dept) : base(name, age, dept)
    {
        // I can able to access properties deep till last child
        var test = base.testProtectedProperties;
    }

    // * I cannot able to override the below method, though it was mentioned as Virtual.
    // Because it was sealed
    // public override void SealedMethod()
    // {}
}

// * I cannot able to do this because the TestInheritance is actually sealed 
// public class TestChildInheritance : TestInheritance
// {
    
// }