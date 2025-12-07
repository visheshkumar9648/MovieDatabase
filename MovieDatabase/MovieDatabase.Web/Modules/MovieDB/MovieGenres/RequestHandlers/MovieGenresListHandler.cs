using MyRow = MovieDatabase.MovieDB.MovieGenresRow;

namespace MovieDatabase.MovieDB;

public interface IMovieGenresListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class MovieGenresListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IMovieGenresListHandler
{
}