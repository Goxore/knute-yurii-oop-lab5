public class ExcelentPupil : Pupil
{
    public ExcelentPupil(string name) : base(name)
    {
        base.performance = Performance.Excellent;
    }

    public override void Study()
    {
        Read();
        Write();
    }

    public override void Read()
    {
        base.KnowledgeLevel += 5;
        base.RelaxLevel += 5;
    }

    public override void Write()
    {
        base.KnowledgeLevel += 10;
        base.RelaxLevel += 5;
    }

    public override void Relax()
    {
        base.KnowledgeLevel -= 7;
        base.RelaxLevel -= 5;
    }

}

