using MyRow = MovieDatabase.MovieDB.GenreRow;

namespace MovieDatabase.MovieDB;

public interface IGenreListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class GenreListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IGenreListHandler
{
}