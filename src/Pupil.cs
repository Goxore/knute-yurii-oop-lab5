public class Pupil
{
    public enum Performance
    {
        Bad,
        Suboptimal,
        Optimal,
        Good,
        Excellent
    }

    public string name;
    public Performance performance;

    private int knowledgeLevel = 50;
    private int relaxLevel = 50;

    public Pupil(string name)
    {
        this.name = name;
    }

    public int KnowledgeLevel { get => knowledgeLevel; set => knowledgeLevel = Clamp(value, 0, 100); }
    public int RelaxLevel { get => relaxLevel; set => relaxLevel = Clamp(value, 0, 100); }

    public void LogPerformance() 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine($"=== {name}'s performance ===");
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine($"performance: {performance.ToString()}");
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine($"knowledgeLevel: {KnowledgeLevel.ToString()}");
        Console.ForegroundColor = ConsoleColor.Blue;
        System.Console.WriteLine($"relaxLevel: {RelaxLevel.ToString()}");
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine($"=== === ===");
        Console.ResetColor();
    }

    public virtual void Study()
    {
        Read();
        Write();
    }

    public virtual void Read()
    {
        KnowledgeLevel += 5;
        relaxLevel -= 5;
    }

    public virtual void Write()
    {
        KnowledgeLevel += 5;
        relaxLevel -= 5;
    }

    public virtual void Relax()
    {
        KnowledgeLevel -= 10;
        relaxLevel += 10;
    }

    public static int Clamp( int value, int min, int max )
    {
        return (value < min) ? min : (value > max) ? max : value;
    }
}

