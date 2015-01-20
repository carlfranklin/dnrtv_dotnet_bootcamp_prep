using System.Collections.Generic;

namespace prep.collections
{
  public class SomeListOfMovies
  {
    IList<Movie> movies;

    public SomeListOfMovies(IList<Movie> movies)
    {
      this.movies = movies;
    }

    public int Count
    {
      get { return movies.Count; }
    }
  }
}