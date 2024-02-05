namespace lab_dotnetBats.Controllers;

[ApiController]
[Route("api/bats")]
public class BatsController : ControllerBase
{
    private readonly BatsService batsService;

    public BatsController(BatsService batsService)
    {
        this.batsService = batsService;
    }

    [HttpPost]
    public ActionResult<Bat> CreateBat([FromBody] Bat batData)
    {
        try
        {
            Bat bat = batsService.CreateBat(batData);
            return Ok(bat);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }

    [HttpGet]
    public ActionResult<List<Bat>> GetBats()
    {
        try
        {
            List<Bat> bats = batsService.GetBats();
            return Ok(bats);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }
}