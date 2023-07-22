using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devgym_csv.app.Models;

namespace devgym_csv.app.Service;

public interface ICsvReader
{
  Task<List<Movie>> createMovieList();
}
