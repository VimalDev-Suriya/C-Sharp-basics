namespace basics.Delegates;

public class AnonymousFunctions
{
    public static void LambdaAnonymousFunctionsExample()
    {
        // * There are 2 different ways,
        // Inline function using Delegate
        // Lambda Expression
        
        // * In Basics we created the function and pointed those function to the delegate pointer.
        // * isntead we can create our own inline functions.
        
        // * We can use the delegate keyword and provide the imeplementation
        //* This was primarly used in older C# syntaxes
        Func<int, int, int> add = delegate(int a, int b)
        {
            return a + b;
        };

        Predicate<int> IsEven = delegate(int a)
        {
            return a % 2 == 0;
        };
        
        // * We can use Lambda expressions for more cleaner way
        Func<int, int, int> Sub = (int a, int b) => a - b;
    }
}