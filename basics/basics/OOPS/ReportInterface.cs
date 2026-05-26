public interface IPrintable
{
    void Print();
}

public interface IExport
{
    void Export(string Path);
}

// * Supports multiple Inheritance
public class Report: IPrintable, IExport
{
    // * While implementing, we dont need to have override unlike Abstarct class or method Overriding
    public void Print()
    {
        Console.WriteLine("Printed");
    }

    public void Export(string path)
    {
        Console.WriteLine("Exported the File");
    }
} 