
public class GoodPupil : Pupil
{
    public GoodPupil(string name) : base(name)
    {
        base.performance = Performance.Good;
    }

    public override void Study()
    {
        Read();
        Write();
    }

    public override void Read()
    {
        base.KnowledgeLevel += 7;
        base.RelaxLevel -= 5;
    }

    public override void Write()
    {
        base.KnowledgeLevel += 7;
        base.RelaxLevel -= 5;
    }

    public override void Relax()
    {
        base.KnowledgeLevel -= 10;
        base.RelaxLevel += 10;
    }

}

