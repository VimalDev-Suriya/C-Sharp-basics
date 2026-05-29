namespace basics.Delegates;

// * Delegates can be invoked by anyone whoever holds the reference
// * This may lead in protecting of delegates.
// So the 'Events' helps us to wrap the delegates, which allows only to multicast them
// To invoke them, we should be using the callback functions provided by it
public class Button
{
    // * "event" type wrapps the Delegate
    // * We can only do += / -= , we cannot execute this OnClick directly
    public event Action<string> OnClick;

    // * To invoke the delegate, we should be using Click
    public void Click(string text)
    {
        // * As this InVoke Method have the access to trigger the delegate
        // * "?" prevents if there was no action in OnClick
        OnClick?.Invoke(text);
    }
}

public class EventsBasics
{
    public static void Basics()
    {
        Button btn = new Button();

        // * Here I just adding the callbacks
        btn.Click("click"); // This will not execute unless we have some handlers in delegates

        // btn.OnClick("test"); // This is not possible; due to event
        
        // * I can attach multiple callbacks
        btn.OnClick += (string text) => Console.WriteLine($"{text} Event Triggered");
        btn.OnClick += (string text) => Console.WriteLine($"{text} Event Triggered");
        btn.OnClick += (string text) => Console.WriteLine($"{text} Event Triggered");
        
        btn.Click("click");
    }
}