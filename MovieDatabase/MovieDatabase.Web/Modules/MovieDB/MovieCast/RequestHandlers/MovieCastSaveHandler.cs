using MyRow = MovieDatabase.MovieDB.MovieCastRow;

namespace MovieDatabase.MovieDB;

public interface IMovieCastSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class MovieCastSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IMovieCastSaveHandler
{
}