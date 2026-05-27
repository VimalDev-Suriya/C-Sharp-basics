# Generics

A Special Fetaure in C#, which helps to write the Class, Methods and Interface without having the static Data types. Instead of writing the separate data types for each methods and classes, we can simply use the `<T>` generic, which has the ability to accept any data types.

## Key Benifits

1. Type Safety - helps to rectify the type casting issues in compile time itself. Because by default type casting errors `InvalidTypeCasting` will be throwned in runtime.
2. Prevents unwanted `boxing` and `unboxing` of variables, which reduces the performance bottlenecks.
3. Code reusability - Same methods can accept any data types.

## Problems that Generic Fixes:

### Problem 1 - Code reusability

#### Without Generics

- Here I should maintain 2 different set of functions with same functionality for 2 different set of data types.
```csharp
class Swapper 
{
    public void SwapInts (ref int a, ref int b){
        int temp = a;
        a = b;
        b = temp;
    }

    public void SwapStrings (ref string a, ref string b){
        string temp = a;
        a = b;
        b = temp;
    }
}

int x = 2; int y = 3;
string a = "a"; string b = "b";
Swapper swap = new();

swap.SwapInts(ref x, ref y);
swap.SwapStrings(ref a, ref b);
```

#### With Generics

```csharp
public class Swapper
{
    public void Swap<T>(ref T a, ref T b){
        T temp = a;
        a = b;
        b = temp;
    }
} 

int x = 2; int y = 3;
string a = "a"; string b = "b";
Swapper swap = new();

swap.Swap<int>(ref x, ref y);
swap.Swap<string>(ref a, ref b);
```

### Problem 2 - Boxing and Unboxing

- Unexpected runtime errors can be solved using Generics

```csharp
class BoxedObject{
    public object Content {get; set;}
}

BoxedObject box = new BoxedObject();
box.Content = 10; // * Internally intType is boxed to object type

// * Later point of the code if there was a casting.
string data = (string) box.Content; // This will throw runtime error.
```

```csharp
public class GenericBoxed<T>{
    public T Content {get; set;}
}

GenericBoxed box = new GenericBoxed<int>();

box.Content = 60;

// * I cannot able to cast that to String in furture, because of Generics
```

## Constraints:

The type of <T> can be abosultly anything, but this itself a problem as we can pass anything. So we need some restriction to have these. So we can use Generics Contraints to prevent the pollution of anything into it. Some of the generic constraints are

- Using `Where` along side of Definitions.
- The 'Where' can accept the Interface, Construction Function, any Data types etc.

```csharp
class Name<T> Where T : new(), BaseClass, IInterface, Int/String...
```
