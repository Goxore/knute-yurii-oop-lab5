public class Exercise2
{
    public static void Run()
    {
        ClassRoom classRoom1 = new ClassRoom(
            new List<Pupil>
            {
                new ExcelentPupil("Rob"),
                new GoodPupil("Mike"),
                new BadPupil("Lucy"),
                new BadPupil("Luke"),
            }
        );

        foreach (var student in classRoom1.classRoom)
        {
            student.Study();
            student.Study();
            student.Relax();
            student.LogPerformance();
        }

    }
}

public class ClassRoom
{
    public List<Pupil> classRoom = new List<Pupil>();

    public ClassRoom(List<Pupil> newPupils)
    {
        if (newPupils.Count != 4)
        {
            throw new ArgumentException("There must be 4 pupils");
        }
        classRoom = newPupils;
    }
}
