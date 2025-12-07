using MyRow = MovieDatabase.MovieDB.MovieCastRow;

namespace MovieDatabase.MovieDB;

public interface IMovieCastRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class MovieCastRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IMovieCastRetrieveHandler
{
}