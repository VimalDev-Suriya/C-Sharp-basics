public class Swapper
{
    public void Swap<T> (ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}

public class Entity { public int Id {get; set;} }

public class EntityManager<T> where T: Entity, new()
{
    public T CreateEntityType()
    {
        // This is possible only because of "new()" constriants
        T entity = new();

        // * This is possible because of Entity Constraints
        entity.Id = 10;

        return entity;
    }
}

public class GenericBasics
{
    public void Basics()
    {
        Example_1();
    }

    public void Example_1()
    {
        int x = 1;
        int y = 2;
        string a = "a";
        string b = "b";
        var swap = new Swapper();

        swap.Swap<int>(ref x, ref y);
        swap.Swap<string>(ref a, ref b);

        Console.WriteLine($"{x} , {y}");
        Console.WriteLine($"{a} , {b}");
    }
}