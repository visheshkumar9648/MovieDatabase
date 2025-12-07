namespace MovieDatabase.MovieDB;

public partial class MovieCastEditorAttribute : CustomEditorAttribute
{
    public const string Key = "MovieDatabase.MovieDB.MovieCastEditor";

    public MovieCastEditorAttribute()
        : base(Key)
    {
    }
}