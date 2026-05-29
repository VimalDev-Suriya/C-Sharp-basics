namespace basics.ExtensionsBasics;

public static class ExtensionsBasics
{
    public static void Basics()
    {
        Console.WriteLine("Extensions Basics");

        // * Here the wordCount is the custom methods which i added at the top of the string
        int count = "Hello There".WordCount();
        Console.WriteLine(count); // 2
    }
}