// * A Event Bus implementation (Publisher and Subscriber) of the events. Which can help us to communicate with different part of the code effectively without any coupling.

// DTO's
public class UserRegistrationEvent
{
    public string Email {get; set;}
} 

public class OrderPlaceEvent
{
    public string OrderId {get; set;}
    public int Amount {get; set;}
}

// * Interface with Generic to handle the Events
// * Here note the Generic Name. Its starting with "T", if we give anyother name apart from T, then we will get error.
public interface IEventHandler<TEvent>
{
    public void Handle(TEvent eventdata);
}

public class EventNotificationHandler: IEventHandler<UserRegistrationEvent>
{
    public void Handle(UserRegistrationEvent eventData)
    {
        Console.WriteLine($"Event was processed and the Mail set to {eventData.Email}");
    }
}

public class InventoryHandler: IEventHandler<OrderPlaceEvent>
{
    public void Handle(OrderPlaceEvent eventData)
    {
        Console.WriteLine($"Order id {eventData.OrderId} was successfully processed the amount of {eventData.Amount} ");
    }
}

public class EventBus
{
    private static readonly Dictionary<Type, List<object>> _eventbus = new();
    public void Subscriber<TEvent>(IEventHandler<TEvent> handler)
    {
        // * System.Type is the placeholder for the runtime calculation type, if we are not sure about the type ahead
        Type eventType = typeof(TEvent);

        if (!_eventbus.ContainsKey(eventType))
        {
            _eventbus[eventType] = new List<object>();
        }

        _eventbus[eventType].Add(handler);
    }

    public void Publisher<TEvent>(TEvent eventData)
    {
        Type eventType = typeof(TEvent);

        if (_eventbus.ContainsKey(eventType))
        {
            var handlers = _eventbus[eventType];

            foreach (var item in handlers)
            {
                // * Typecasting to the corresponding type
                var typehandler = (IEventHandler<TEvent>) item;
                typehandler.Handle(eventData);
            }
        }
    }
}