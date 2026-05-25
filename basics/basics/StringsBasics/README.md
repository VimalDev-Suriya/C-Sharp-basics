# Strings

Strings in C# are the **reference types** and **immutable**,but they look like a Value types. So whenever we are trying to perform any string operations like re-asigning, concatenation etc there will be a new memory will be allocated for them.

```csharp
str += "new text"
```

## Problems

Everytime we perform the above operations we will be doing,
1. New block memory will be created for each concatenation, if this was present inside a loop
2. If the string is huge then there will be a performance issue and lots of new reference of the strings will be created

## Fix:

Using the `StringBuilder` class, creates the Buffer which can `Mutate` the string and will not create the new memory everytime.

- So use normal strings for CONSTANTS or any string value which will not frequently change
- Use STringBuilder for Dynamic string contents that varies based on the time.

**Note**:
I can use all strings methods in Stringbuilder also, only difference is the memory allocation