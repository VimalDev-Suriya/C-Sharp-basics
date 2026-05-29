namespace basics.Delegates;

public static class DelegateBasics
{
    // * Creating the Custom Delegate
    // * Using Delegate keyword we can create the delegate message
    // * The Method signatures (params and return type) should exactly match the method we point
    // * Step 1: Declaring the Delegate
    public delegate void LogMessage(string message);
    
    public static void Basics()
    {
        Console.WriteLine("Delegates Basics");
        
        CustomeDelegateExample();
        MuticastDelegateExample();
        BuiltInDelegateExample();
        EventsBasics.Basics();

        var aggrecate = new AggregateBasics();
        aggrecate.Basics();
    }

    public static void CustomeDelegateExample()
    {
        Console.WriteLine("Custome Delegate Example");
        
        // * Intantiation of the delegate function with the new function definition
        LogMessage logMessage = WriteMessage;
        // * Function invokation
        logMessage("Hello World!");
    }

    public static void MuticastDelegateExample()
    {
        Console.WriteLine("Muticast Delegate Example");
        
        LogMessage logMessage = WriteMessage;
        logMessage += SendEmail; // * Attaching the methods into single Delegate

        logMessage("sdk@example.com");
        
        // * Detaching the method, so the writemessage will not be executed
        logMessage -= WriteMessage;
        
        logMessage("test@test.com");
    }

    // * Built in Delegates
    public static void BuiltInDelegateExample()
    {
        // * Below Syntax will work for all latest c#
        // * We call this as Action.
        // * If you see I used "var", which can accept dynamic type at runtime (which is abosultely correct, but always try to give type)
        // var LogMessage = WriteMessage;
        
        Action<string> LogMessage = WriteMessage;
        LogMessage("'Action type of Delegate'");
        
        // * Func type - Use it whenever there is the place where we need to return the value from  methods
        // Here we used 3 types
        // 1st & 2nd Input type
        // 3rd return type of the method
        Func<int, int, int> op = Add;
        var result = op(20, 10);
        Console.WriteLine(result);
        
        // * Perdicate type -> The return type should always be boolean.
        Predicate<int> isEven = IsEven;
        var resultPredicate = isEven(7);
        Console.WriteLine(resultPredicate);
    }

    public static void WriteMessage(string message)
    {
        Console.WriteLine($"Writing the Log Message {message}");
    }

    public static void SendEmail(string email)
    {
        Console.WriteLine($"Writing the Email {email}");
    }

    public static int Add(int a, int b) => a + b;
    public static int Sub(int a, int b) => a - b;
    
    public static bool IsEven(int a) => a % 2 == 0;
}