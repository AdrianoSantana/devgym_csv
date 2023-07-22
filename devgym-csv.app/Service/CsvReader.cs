using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devgym_csv.app.Models;
using Microsoft.VisualBasic.FileIO;

namespace devgym_csv.app.Service;
public class CsvReader : ICsvReader
{
  private readonly string _csvPath;
  public CsvReader(string csvPath)
  {
    this._csvPath = csvPath;
  }

  public async Task<List<Movie>> createMovieList()
  {
    var result = new List<Movie>();
    using (TextFieldParser csvParser = new TextFieldParser(this._csvPath))
    {
      csvParser.CommentTokens = new string[] { "#" };
      csvParser.SetDelimiters(new string[] { "," });
      csvParser.HasFieldsEnclosedInQuotes = true;

      // Skip the row with the column names
      csvParser.ReadLine();

      while (!csvParser.EndOfData)
      {
        // Read current line fields, pointer moves to the next line.
        string[] fields = csvParser.ReadFields();
        string Name = fields[0];
        string Address = fields[1];
      }
    }
    return result;
  }
}
