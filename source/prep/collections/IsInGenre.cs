namespace prep.collections
{
  public class IsInGenre
  {
    Genre genre;

    public IsInGenre(Genre genre)
    {
      this.genre = genre;
    }

    public bool matches(Movie movie)
    {
      return movie.genre == genre;
    } 
  }
}