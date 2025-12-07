using MyRow = MovieDatabase.MovieDB.MovieRow;

namespace MovieDatabase.MovieDB;

public interface IMovieSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class MovieSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IMovieSaveHandler
{
}