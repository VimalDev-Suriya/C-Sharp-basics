public class Animal
{
    public virtual void Speak() => Console.WriteLine("....");
}

public class Cat : Animal
{
    public override void Speak() => Console.WriteLine("Meow Meow");
}

public class Dog : Animal
{
    // * a "new" keyword here will hide the current implementation
    // On calling this fucntion with Dog's instance, we will be executing the parents method
    public new void Speak() => Console.WriteLine("Woff Wofff");
}