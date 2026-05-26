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


## Polymorphism:

## Abstraction vs Interface:

## Encapsulation:


## Static keyword

- We cannot access non-static methods from the Static Method
- We can access Non Static class from Static Method
- We dont need instance to access the Static Methods