using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgym_csv.app.Models;
public class Movie
{
  public int Id { get; set; }
  public string? Title { get; set; }
  public int Year { get; set; }
  public string? Genres { get; set; }

  public Movie(int id, string title, int year, string genres)
  {
    this.Id = id;
    this.Title = title;
    this.Year = year;
    this.Genres = genres;
  }
}
