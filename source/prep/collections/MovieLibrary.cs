using System;
using System.Collections.Generic;
using prep.utility;

namespace prep.collections
{
  public class MovieLibrary
  {
    IList<Movie> movies;

    public MovieLibrary(IList<Movie> list_of_movies)
    {
      this.movies = list_of_movies;
    }

    public IEnumerable<Movie> all_movies()
    {
      return movies.one_at_a_time();
    }

    public void add(Movie movie)
    {
        // If this movie object is already here, bail
        foreach (var m in movies)
        {
            if (m == movie)
            {
                return;
            }
        }

        // If a movie exists with the same title, bail
        foreach (var m in movies)
        {
            if (m.title == movie.title)
            {
                return;
            }
        }

        movies.Add(movie);
    }

    public IEnumerable<Movie> all_movies_published_by_pixar()
    {
        foreach (var m in movies)
        {
            if (m.production_studio == ProductionStudio.Pixar)
                yield return m;
        }
    }

    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
    {
        foreach (var m in movies)
        {
            if (m.production_studio == ProductionStudio.Disney || m.production_studio == ProductionStudio.Pixar)
                yield return m;
        }
    }

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {
        foreach (var m in movies)
        {
            if (m.production_studio != ProductionStudio.Pixar)
                yield return m;
        }
    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
        foreach (var m in movies)
        {
            if (m.date_published.Year > year)
                yield return m;
        }
    }

    public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
    {
        foreach (var m in movies)
        {
            if (m.date_published.Year >= startingYear && m.date_published.Year <= endingYear)
                yield return m;
        }
    }

    public IEnumerable<Movie> all_kid_movies()
    {
        foreach (var m in movies)
        {
            if (m.genre == Genre.kids)
                yield return m;
        }
    }

    public IEnumerable<Movie> all_action_movies()
    {
        foreach (var m in movies)
        {
            if (m.genre == Genre.action)
                yield return m;
        }
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_title_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_title_ascending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
    {
      throw new NotImplementedException();
    }
  }
}
