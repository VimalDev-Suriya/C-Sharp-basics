# Basics of C#

## Variable Types

C-Sharp is strongly typed language

1. Value types - values will be copied when assigned
   1. `int`, `bool`, `char`, `double`, `enum`, and `struct`
2. Reference types - memory refernces will be copied when reassigned
   1. `array`, `objects`, `string` and `class`

### To Determine the type

```csharp
int a = 10;
long b = a;
Console.WriteLine(b.GetType()); // System.Int64
```

## Strings: