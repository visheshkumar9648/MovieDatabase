using MyRow = MovieDatabase.MovieDB.PersonRow;

namespace MovieDatabase.MovieDB;

public interface IPersonRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class PersonRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IPersonRetrieveHandler
{
}