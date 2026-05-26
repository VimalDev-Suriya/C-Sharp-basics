public class DictioneryBasics
{
    public void Basics()
    {
        Console.WriteLine("Dictionery");
        // * Used to store the Key Value types
        Dictionary<string, int> scores = new();

        scores["ravi"] = 90;
        scores["kavi"] = 100;
        scores["tes"] = 75;

        scores.TryGetValue("ravi", out int score);

        Console.WriteLine(score);
    }
} 