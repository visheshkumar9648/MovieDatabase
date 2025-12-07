using MyRow = MovieDatabase.MovieDB.GenreRow;

namespace MovieDatabase.MovieDB;

public interface IGenreSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class GenreSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IGenreSaveHandler
{
}