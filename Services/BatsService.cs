
namespace lab_dotnetBats.Services;

public class BatsService(BatsRepository repo)
{
    private readonly BatsRepository repo = repo;

    internal List<Bat> GetBats()
    {
        List<Bat> bats = repo.GetBats();
        return bats;
    }
}