


public class BadPupil : Pupil
{
    public BadPupil(string name) : base(name)
    {
        base.performance = Performance.Bad;
    }

    public override void Study()
    {
        Read();
        Write();
    }

    public override void Read()
    {
        base.KnowledgeLevel += 3;
        base.RelaxLevel -= 6;
    }

    public override void Write()
    {
        base.KnowledgeLevel += 3;
        base.RelaxLevel -= 6;
    }

    public override void Relax()
    {
        base.KnowledgeLevel -= 10;
        base.RelaxLevel += 20;
    }

}

