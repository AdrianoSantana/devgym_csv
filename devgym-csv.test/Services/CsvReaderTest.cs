using devgym_csv.app.Service;

namespace devgym_csv.test.Services;
public class CsvReaderTest
{
  [Fact]
  public void should_call_csvReader_with_correct_value()
  {
    string csvPath = "any_path";
    var sut = new CsvReader(csvPath);

  }
}
