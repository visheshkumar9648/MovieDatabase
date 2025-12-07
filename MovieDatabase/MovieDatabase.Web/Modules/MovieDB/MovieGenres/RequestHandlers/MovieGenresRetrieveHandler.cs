using MyRow = MovieDatabase.MovieDB.MovieGenresRow;

namespace MovieDatabase.MovieDB;

public interface IMovieGenresRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class MovieGenresRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IMovieGenresRetrieveHandler
{
}