namespace MovieDatabase.MovieDB.Columns;

[ColumnsScript("MovieDB.MovieCast")]
[BasedOnRow(typeof(MovieCastRow), CheckNames = true)]
public class MovieCastColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int MovieCastId { get; set; }
    //public string MovieTitle { get; set; }

    [EditLink, Width(250)]
    public string PersonFullName { get; set; }
    [EditLink, Width(250)]
    public string Character { get; set; }
}