# Delegates

A delegate in C# is a type-safe **function pointer** that holds a reference to one or more methods with a specific signature. 

It treats methods as **first-class objects**, allowing you to pass functionality as arguments, store them in variables, and execute them dynamically at runtime. 

There are 3 steps to have the delegate functions

1. Declaration
2. Instantiate
3. Invoke

## Multicast Delegate:

A single delegate instance can hold references to multiple methods simultaneously. 

When you invoke a multicast delegate, all hooked methods are executed sequentially in the order they were added

- We can use "-=" for detaching and "+=" for attaching the methods to the single delegate pointer.

**Note**:

Warning on Return Values: If a multicast delegate points to methods that return a value (e.g., int), invoking the delegate will run all methods, but only the return value of the last method added will be caught

But there are other option to chain the delegates and passing the result from one delegate to another.

## Types of Built-in Delegates:

1. `Action` - Always use action for the methods that returns `void`. We can use 16 parameters while using action.