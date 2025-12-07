namespace MovieDatabase.MovieDB.Pages;

[PageAuthorize(typeof(PersonRow))]
public class PersonPage : Controller
{
    [Route("MovieDB/Person")]
    public ActionResult Index()
    {
        return this.GridPage<PersonRow>("@/MovieDB/Person/PersonPage");
    }
}