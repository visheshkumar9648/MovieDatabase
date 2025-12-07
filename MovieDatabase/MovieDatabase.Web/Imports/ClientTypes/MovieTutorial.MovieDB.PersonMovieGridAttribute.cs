namespace MovieTutorial.MovieDB;

public partial class PersonMovieGridAttribute : CustomEditorAttribute
{
    public const string Key = "MovieTutorial.MovieDB.PersonMovieGrid";

    public PersonMovieGridAttribute()
        : base(Key)
    {
    }
}