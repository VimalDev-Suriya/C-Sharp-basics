namespace basics.OOPS;

// * Here we use ":" to inherit from Parent class
public class EmployeeInheritance : Person
{
    private string _department;

    public EmployeeInheritance(string name, int age, string dept) : base(name, age)
    {
        _department = dept;
    }
}