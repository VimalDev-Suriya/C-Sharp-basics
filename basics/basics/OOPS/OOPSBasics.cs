using basics.OOPS;

public class OOPSBasics
{
    static public void Basics()
    {
        InheritanceExample();
        PolymorphismExample();
        AbstractionExample();
    }

    static void InheritanceExample()
    {
        Console.WriteLine("Inheritance Example");

        Person p1 = new Person("Suriya", 10);
        EmployeeInheritance emp1 = new EmployeeInheritance("Keerthana", 25, "Doctor");
        
        Console.WriteLine(emp1.Describe());
    }

    static void AbstractionExample()
    {
        Shape square = new Square
        {
          Sides = 30  
        };

        square.Print();

        Shape rectangle = new Reactangle
        {
            Length = 120,
            Width = 100
        };

        rectangle.Print();
    }

    static void PolymorphismExample()
    {
        Cat cat = new Cat();
        cat.Speak(); // * Meow Meow

        Dog dog = new Dog();
        dog.Speak(); // * Woff Woff

        // * Even after using "new", why I am not able to base class method execution?
        // Because it depands on how i created the instance, I created the instanace with Child class and used Child type
        // So compiler will pick the Child class implementation, irrespective of using "new" or "override".

        // * as the fix we can use
        Animal catWithAnimalType = new Cat();
        Animal dogWithAnimalType = new Dog();

        catWithAnimalType.Speak(); // Meow Meow
        dogWithAnimalType.Speak(); // ...
    }
}