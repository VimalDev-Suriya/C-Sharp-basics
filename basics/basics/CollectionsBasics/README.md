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