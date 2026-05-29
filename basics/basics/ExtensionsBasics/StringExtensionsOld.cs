namespace basics.ExtensionsBasics;

// * To Use this, we should be including this class at the top level.
// * Make sure that we use STATIC type class and Methods
public static class StringExtensionsOld
{
    // * the "this" keyword will be bounded to the data type which was called.
    // Here the "this" keyword binds to the String data type
    // SO the WordCount function can be accessed in string types
    public static int WordCount(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;
        
        var strings =  text.Split(' ');

        return strings.Length;
    }
}