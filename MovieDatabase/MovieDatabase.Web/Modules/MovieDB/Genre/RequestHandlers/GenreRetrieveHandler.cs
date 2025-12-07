using MyRow = MovieDatabase.MovieDB.GenreRow;

namespace MovieDatabase.MovieDB;

public interface IGenreRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class GenreRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IGenreRetrieveHandler
{
}