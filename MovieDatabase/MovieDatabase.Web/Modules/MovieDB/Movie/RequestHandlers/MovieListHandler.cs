using MyRow = MovieDatabase.MovieDB.MovieRow;
using MyRequest = MovieDatabase.MovieDB.MovieListRequest;

namespace MovieDatabase.MovieDB;

public interface IMovieListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class MovieListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IMovieListHandler
{

}