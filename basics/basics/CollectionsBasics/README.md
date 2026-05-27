# Collections in C#:

## Lists:

Lists are the Dynamic Sized collection which can hold dynamic typed values. Uses Generics to accet anytype of data.

- Variable size - Can either be increased or decreased in Size
- Indexed based access
- Similar to arrys in JS
- Efficient than inbuilt Arrays and ArrayList
    - Arrays are faster, but fixed in Size.
    - ArrayList can accept any type of data, but we should do `boxing` and `unboxing` to perform certain actions which are high performance impact actions
- They can `accept Duplicates`
- Ordered

## Dictionery:

A Key-Value pair data collection.

## Hashsets:

A Data structure which stores `unordered` and `unique` items. It is very faster than List and literatly takes O(1) time for seraching, but List takes nearly `O(n) in average case`. Because it internally uses hash table for look up.

### PROS
- It cannnot store duplicates
- It will be under `System.Collection.Generics`

### CONS
- `Memory Overhead` because we need to store the hashtable, so the tradeoff between speed vs memory.
If we need speed over memory, Hashset is suitable.
- Looping over Hashset is a performance impact action, as there are lot more empty memory spaces due to hashes. `Looping over list is faster than Hashset`.

## Stack and Queues:

C# provides the default Stack and Queues. Currently I am not planned to Dive deep into it

```csharp
var q = new Queue();
```