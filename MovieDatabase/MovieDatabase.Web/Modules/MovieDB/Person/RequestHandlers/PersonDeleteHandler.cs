using MyRow = MovieDatabase.MovieDB.PersonRow;

namespace MovieDatabase.MovieDB;

public interface IPersonDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class PersonDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IPersonDeleteHandler
{
}