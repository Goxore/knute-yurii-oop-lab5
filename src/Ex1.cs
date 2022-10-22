public class Exercise1
{
    public static void Run()
    {
        ColorPrinter printer = new ColorPrinter();
        printer.Print("texttexttext");
    }
}

public class Printer
{
    public virtual void Print(string value)
    {

        System.Console.WriteLine(value);
    }   
}

public class ColorPrinter: Printer
{
    public override void Print(string value)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        base.Print(value);
        base.Print($"value typeype: {value.GetType()}");
        Console.ResetColor();
    }
}
