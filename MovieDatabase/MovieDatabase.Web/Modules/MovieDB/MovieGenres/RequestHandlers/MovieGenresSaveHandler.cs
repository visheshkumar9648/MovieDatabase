using MyRow = MovieDatabase.MovieDB.MovieGenresRow;

namespace MovieDatabase.MovieDB;

public interface IMovieGenresSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class MovieGenresSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IMovieGenresSaveHandler
{
}