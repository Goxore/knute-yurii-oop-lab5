public class Exercise3
{
    public static void Run()
    {
        Console.WriteLine("Insert a product key: \n");
        var key = Console.ReadLine();
        var path = @"/home/yurii/Projects/uni/OOP/lab5/src/text";

        var documentWorker = new DocumentWorker(path);
        documentWorker.OpenDocument();
    }
}

public class DocumentWorker
{
    public string path;
    public string? text;

    public DocumentWorker(string path)
    {
        this.path = path;
    }

    public virtual void OpenDocument()
    {
        text = File.ReadAllText(path + ".rmd");
        System.Console.WriteLine("Документ відкритий");
    }

    public virtual void EditDocument()
    {
        System.Console.WriteLine("Правка документа доступна у версії Про");
    }

    public virtual void SaveDocument()
    {
        System.Console.WriteLine("Збереження документа доступне у версії Про");
    }
}

public class ProDocumentWorker : DocumentWorker
{
    public ProDocumentWorker(string path) : base(path)
    {
        base.path = path;
    }

    public override void EditDocument()
    {
        if (text != null)
        {
            base.text += @"\n added text";
            System.Console.WriteLine("Документ відредаговано");
        }
        else
        {
            System.Console.WriteLine("Документ не відкрито");
        }
    }

    public override void SaveDocument()
    {

        System.Console.WriteLine("Документ збережений в новому форматі");
        StreamWriter file = new(base.path + ".md");
        file.WriteLine(text);
        System.Console.WriteLine("Документ збережено у старому форматі");
    }
}

public class ExpertDocumentWorker : DocumentWorker
{
    public ExpertDocumentWorker(string path) : base(path)
    {
        base.path = path;
    }

    public override void SaveDocument()
    {
        System.Console.WriteLine("Документ збережений в новому форматі");
        StreamWriter file = new(base.path + ".rmd");
        file.WriteLine(text);
    }
}
