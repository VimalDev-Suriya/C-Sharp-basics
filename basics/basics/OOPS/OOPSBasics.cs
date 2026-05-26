using basics.OOPS;

public class OOPSBasics
{
    static public void Basics()
    {
        InheritanceExample();
        PolymorphismExample();
        AbstractionExample();
        InterfaceExample();
        EncapsulationExample();
    }

    static void EncapsulationExample()
    {
        BankAccountEncapsulation acc = new BankAccountEncapsulation(12345678);

        Console.WriteLine($"Balance of the AccounNumber={acc.AccountNumber} is balance={acc.Balance}");

        // * Here i cannot change the balance directly
        acc.Deposit(1000);
        acc.Deposit(2000);
        Console.WriteLine($"Balance of the AccounNumber={acc.AccountNumber} is balance={acc.Balance}");
        acc.Deposit(1000);
        acc.Withdraw(3000);
        Console.WriteLine($"Balance of the AccounNumber={acc.AccountNumber} is balance={acc.Balance}");
        
        // * Here I cannot able to set the accountnumber 
        BankAccountEncapsulationV2 acc1 = new BankAccountEncapsulationV2
        {
            AccountNumber = 1234556
        };

        // * I cannot able to set this, because this is init only [property]
        // acc1.AccountNumber = 123;

        Console.WriteLine($"Balance of the AccounNumber={acc1.AccountNumber} is balance={acc1.Balance}");

        // * Here i cannot change the balance directly
        acc1.Deposit(1000);
        acc1.Deposit(2000);
        Console.WriteLine($"Balance of the AccounNumber={acc1.AccountNumber} is balance={acc1.Balance}");
        acc1.Deposit(1000);
        acc1.Withdraw(3000);
        Console.WriteLine($"Balance of the AccounNumber={acc1.AccountNumber} is balance={acc1.Balance}");
    }

    static void InheritanceExample()
    {
        Console.WriteLine("Inheritance Example");

        Person p1 = new Person("Suriya", 10);
        EmployeeInheritance emp1 = new EmployeeInheritance("Keerthana", 25, "Doctor");
        
        Console.WriteLine(emp1.Describe());
    }

    static void InterfaceExample()
    {
        OrderCheckout order = new OrderCheckout();

        // * Here i can use both Stripe and Paypal processing
        // Interface gives the can do oppurtunity with 2 different streams
        Paypal paypal = new Paypal();
        Stripe stripe = new Stripe();

        order.ProcessPayment(102, paypal);
        order.ProcessPayment(100, stripe);
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