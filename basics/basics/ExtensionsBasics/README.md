# Extensions:

In C#, extensions allow you to add new functionality to existing types (like classes, interfaces, or structs) without altering their source code, inheriting from them, or recompiling them.

There are 2 ways to use the extensions:

1. Using `this` an older way of handling extension
2. Extension Members & Blocks (.Net 10 + / c# 14+)

Always use **Static class and methods**, to access the `this` keywords.