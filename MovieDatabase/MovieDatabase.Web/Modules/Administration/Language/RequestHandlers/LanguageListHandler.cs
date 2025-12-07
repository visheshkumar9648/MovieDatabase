using MyRow = MovieDatabase.Administration.LanguageRow;

namespace MovieDatabase.Administration;
public interface ILanguageListHandler : IListHandler<MyRow> { }

public class LanguageListHandler(IRequestContext context)
    : ListRequestHandler<MyRow>(context), ILanguageListHandler
{
}