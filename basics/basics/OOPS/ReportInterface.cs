public interface IPrintable
{
    void Print();
}

public interface IExport
{
    void Export(string Path);
}

public class Report: IPrintable, IExport
{
    public void Print()
    {
        Console.WriteLine("Printed");
    }

    public void Export(string path)
    {
        Console.WriteLine("Exported the File");
    }
} 