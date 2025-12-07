using MyRow = MovieDatabase.Administration.RoleRow;

namespace MovieDatabase.Administration;
public interface IRoleDeleteHandler : IDeleteHandler<MyRow> { }

public class RoleDeleteHandler(IRequestContext context)
    : DeleteRequestHandler<MyRow>(context), IRoleDeleteHandler
{
}