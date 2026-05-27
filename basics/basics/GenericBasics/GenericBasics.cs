public class Swapper
{
    // * Remember, the "T" next to Swap function name is the one that passes the type to its parametes (ref T a);
    // * If we are not refceiving the value from the caller function, then we can't able to access them in both function and its params
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

    public void EventBusExample()
    {
        EventBus eventbus = new();

        eventbus.Subscriber<UserRegistrationEvent>(new EventNotificationHandler());

        eventbus.Publisher(new UserRegistrationEvent
        {
            Email = "test@test.com"
        });
    }

    public void Example_1()
    {
        int x = 1;
        int y = 2;
        string a = "a";
        string b = "b";
        var swap = new Swapper();

        // * Here we need to pass the <int> next to generic function call
        swap.Swap<int>(ref x, ref y);
        swap.Swap<string>(ref a, ref b);

        Console.WriteLine($"{x} , {y}");
        Console.WriteLine($"{a} , {b}");
    }
}