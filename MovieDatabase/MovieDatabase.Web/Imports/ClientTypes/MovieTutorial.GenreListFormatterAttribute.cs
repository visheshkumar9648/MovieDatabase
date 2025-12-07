namespace MovieTutorial;

public partial class GenreListFormatterAttribute : CustomFormatterAttribute
{
    public const string Key = "MovieTutorial.GenreListFormatter";

    public GenreListFormatterAttribute()
        : base(Key)
    {
    }
}