using MyRow = MovieDatabase.MovieDB.PersonRow;

namespace MovieDatabase.MovieDB;

public interface IPersonListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class PersonListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IPersonListHandler
{
}