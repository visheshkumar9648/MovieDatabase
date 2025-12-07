using MyRow = MovieDatabase.MovieDB.MovieCastRow;

namespace MovieDatabase.MovieDB;

public interface IMovieCastDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class MovieCastDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IMovieCastDeleteHandler
{
}