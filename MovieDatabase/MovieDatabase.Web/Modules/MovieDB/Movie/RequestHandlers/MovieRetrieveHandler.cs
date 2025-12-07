using MyRow = MovieDatabase.MovieDB.MovieRow;

namespace MovieDatabase.MovieDB;

public interface IMovieRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class MovieRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IMovieRetrieveHandler
{
}