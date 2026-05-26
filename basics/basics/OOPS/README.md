# Object-Oriented Programming in C#

## Class:

- By default classes are `internal` access modifier, Which cannot be accessed outside another project/solution
- The constructor name should be as same as `class name`
- Make sure to create the public constructor, if we create a private/protected constructor, then we cannot be able to create the instance using ``new keyword`` 
  - **Prevents inheritance**: Other classes cannot inherit from it because the derived class cannot call the base constructor.

### Initialization of Class:

There are 2 different types of class initialization. Both of them depands on how we are implemented the class

**Example 1: Constructor**
```csharp
public class Person
{
    private string _name;
    private int _age;
    
    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }
}

// * To Initialize the class
// * Since we used constructor function we can initialize them as below
Person P = new Person("Suriya", 10);
```

**Example 2: Object Initializer**

When we are okay to use default constructor and using setter and getter, we can initialize them differently. We call this as ``Object Initializer`` syntax
```csharp
public class Person
{
    // Fields (private by convention)
    private string _name;

    // * Getter and setter (Explicit way)
    public string Name 
    {
        get => _name;
        set => _name = value
    }
    
    // * Getter and setter Shortand
    public int Age
    {
        get; set;
    }
}

// * To Initialize the class
// * Since we used constructor function we can initialize them as below
Person P = new Person
{
    Name = "Suriya",
    Age = 20
};
```

**Which one should we use?** <br>
**Use Syntax 1 (Constructor)** if we want to make sure a person cannot be created without a name and age. <br>

**Use Syntax 2 (Object Initializer**) if we want clean, readable code and the properties are optional.

## Access Modifiers:

It provides the explicitly on how the data should be accessed by the other objects. There are different types of access modifiers

1. Public
   2. Can be accessible from anywhere.
2. Private
   3. Default for all Class methods and properties. **Cannot** be accessed outside the class.
3. Protected
   4. Can be accessed in Same class and Child class
4. Internal
   5. Can be accessible from same assembly/project.
   6. By default all classes are Internal
5. Private Protected
   6. Same class or derived classes in the same assembly.
6. Protected Internal
   6. Same assembly OR derived classes.

**Note**: Always explicitly set the Access specifier, this will set the intent of the class for the readers

## Inheritance:

A process of extending the methods and properties from the parent class, so that we could organize application effectively.

- We use `:` to extend from the parent class in C#
- Always pass the required properties to parent class whenever required
- We use `base` keyword to access the properties and methods from Parent class
- `sealed`, `virtual` and `override` are 2 properties for Method Overriding concept in C#. 
    - Virtual is used in parent class, which states that the corresponding method might be overided
    - Override is used in child class which actually override the method
    - Sealed is the property which can be used in conjustion with both class and its methods,
        - If a class is sealed, then we cannot able to inherit them.
        - If a method is sealed, We cannot override them in child class. For functions alone the Sealed is always used in conjustion with Virtual.
- Supports only Single and Multilevel. Multiple inheritance was not supported. We can use interface on that occasion.

## Polymorphism (Many forms):

One of the Key OOPS concept, where it provides the ability to override the implementation of methods. There are 2 types of polymorphism

1. Static (compile time)
    - Method Overloading - Same method name, but different set of paramaters
2. Dynamic (runtime)
    - Method Overriding

## Abstraction vs Interface:

### Abstraction:

Abstraction is the process of hiding the complex implementation and exposing only the required fields and methods. It answers what object does, rather than how it does.

- `Abstract methods` can be implemented only within the `abstract class`.
- We will be using `override` property to override the abstract methods in the derived class
- Abstract methods are the `function declartions`, we `should always override` them in child/derived class by `defining the function`.

**Note**: Always use Abstract methods when there need to have a shared `state` or a `base implementation`. <br>

**It gives the ability of `is-a` relationship**.

### Interface:

A blueprint or the schema, which defines the strict contract of behaviours. It answers `what exactly the class must do`, without any implementation.

1. Provides the Ability to perform `multiple inheritance`
2. Always have `I` as the start while defining the name of Interface
3. All the methods in interface are by default `public` access modifier
4. Interface should not have any state i.e properties
5. **Its very powerful and ability to provide the loose coupling (highly used in dependency injection of multiple classes that was implements the interface)**

**It gives the ability of `can-do` relationship**

## Encapsulation:

A process of hiding or protecting the data from the external modifications. Using varies properties we can hide or protect the data

1. Access Modifiers
2. Getter and Setter properties

## Static keyword

- We cannot access non-static methods from the Static Method
- We can access Non Static class from Static Method
- We dont need instance to access the Static Methods