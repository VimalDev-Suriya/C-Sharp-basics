namespace basics.LINQBasics;

public class Employee
{
    public string Name { get; set; }
    public string Dept{ get; set; }
    public double Salary { get; set; }
}

public static class LINQBasics
{
    static List<Employee> employees = new List<Employee> {
        new() { Name="Ravi",   Dept="IT",  Salary=60000 },
        new() { Name="Priya",  Dept="HR",  Salary=55000 },
        new() { Name="Arun",   Dept="IT",  Salary=70000 },
        new() { Name="Sneha",  Dept="HR",  Salary=48000 },
        new() { Name="Kiran",  Dept="IT",  Salary=80000 },
    };
    
    public static void Basics()
    {
        Console.WriteLine("LINQ Basics");
        
        WhereMethod();
        SelectMethod();
        GroupByMethod();
        DeferExample();
    }

    public static void WhereMethod()
    {

        // * Where is actually a filter (similar to Filter in JS);
        IEnumerable<Employee> employeeDetail = employees.Where(x => x.Name == "Ravi");
        
        Console.WriteLine(employeeDetail.Count());

        foreach (var employee in employeeDetail)
        {
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Dept);
            Console.WriteLine(employee.Salary);
        }
    }

    public static void SelectMethod()
    {
        // * Similar to map in JS
        IEnumerable<string> names = employees.Select(x => x.Name);
        
        // * Results will only have the data which satisfies the condition
    }

    public static void GroupByMethod()
    {
        IEnumerable<IGrouping<string, Employee>> deprt = employees.GroupBy(x => x.Dept);

        foreach (var group in deprt)
        {
            Console.WriteLine($"{group.Key} -  {group.Count()} employees");
            foreach (var employee in group)
            {
                Console.WriteLine($"{employee.Name} - {employee.Dept}");
            }
        }
    }

    public static void FirstDefaultMethods()
    {
        // 5. First / FirstOrDefault
        Employee? top = employees.First(e => e.Salary > 70000);    // throws if none
        Employee? top2 = employees.FirstOrDefault(e => e.Salary > 90000); // null if none
    }

    public static void DeferExample()
    {
        var nums = new List<int> { 1, 2, 3, 4, 5 };

        // DEFERRED — query is NOT executed here
        var query = nums.Where(n => {
            Console.WriteLine($"Checking {n}");
            return n > 2;
        });

        Console.WriteLine("Query defined");

        // Executed HERE — when iterated
        foreach (var n in query) Console.WriteLine(n);
        // Output: "Query defined", then checking happens

        // Force immediate execution with ToList() / ToArray()
        var instant = nums.Where(n => n > 2).ToList(); // runs NOW
        // * Beware of wiring up with toList functionality 
    }
}