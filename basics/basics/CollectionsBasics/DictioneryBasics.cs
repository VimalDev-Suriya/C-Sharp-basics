public class DictioneryBasics
{
    public void Basics()
    {
        Console.WriteLine("Dictionery");
        // * Used to store the Key Value types
        Dictionary<string, int> scores = new();

        // To Add the data into the Dictionery
        scores["ravi"] = 90;
        scores["kavi"] = 100;
        scores.Add("suriya", 75);

        // To remove the value
        scores.Remove("kavi");

        // Contains - can be both Key and Value
        // Key -> O(1)
        // Value -> O(n)
        Console.WriteLine($"Does Scores Dictionery contains kavi? {scores.ContainsKey("kavi")}");
        Console.WriteLine($"Does Scores Dictionery contains 100? {scores.ContainsValue(100)}");

        // * To Extract the value by giving the Key
        scores.TryGetValue("ravi", out int score);
        Console.WriteLine(score);
        Console.WriteLine($"{scores["ravi"]}");

        // * Looping over the Dictionery
        foreach (var (key, value) in scores)
        {
            Console.WriteLine($"{key} => {value}");
        }

        // * To Get all Keys
        var keys = scores.Keys;
        foreach (var key in keys)
        {
            Console.WriteLine($"Keys {key}");
        }

        var values = scores.Values;
        foreach (var value in values)
        {
            Console.WriteLine($"Values {value}");
        }
    }
} 