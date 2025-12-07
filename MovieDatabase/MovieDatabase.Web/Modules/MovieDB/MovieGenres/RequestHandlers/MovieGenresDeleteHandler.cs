using MyRow = MovieDatabase.MovieDB.MovieGenresRow;

namespace MovieDatabase.MovieDB;

public interface IMovieGenresDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class MovieGenresDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IMovieGenresDeleteHandler
{
}