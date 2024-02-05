

namespace lab_dotnetBats.Repositories;

public class BatsRepository
{

    private readonly List<Bat> FakeDB = [
        new Bat("Molly"),
        new Bat("Henry")
    ];

    internal Bat CreateBat(Bat batData)
    {
        FakeDB.Add(batData);
        return batData;
    }

    internal List<Bat> GetBats()
    {
        return FakeDB;
    }


}