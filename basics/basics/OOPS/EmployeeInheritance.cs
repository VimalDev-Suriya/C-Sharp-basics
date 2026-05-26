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
    public string Describe()
    {
        return "";
    }
}