using MyRow = MovieDatabase.MovieDB.MovieCastRow;

namespace MovieDatabase.MovieDB;

public interface IMovieCastListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class MovieCastListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IMovieCastListHandler
{
}