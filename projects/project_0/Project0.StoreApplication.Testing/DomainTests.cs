using Xunit;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Testing
{
  public class DomainTests
  {
    [Fact]
    public void Test_Store()
    {
      var sut = new Colma();

      sut.Name = "New name";

      var actual = sut.Name;

      Assert.Equal("New name", actual);
    }

    [Fact]
    public void Test_West()
    {
      var sut = new West();

      sut.Name = "New name";

      var actual = sut.Name;

      Assert.Equal("New name", actual);
    }

    [Fact]
    public void Test_Central()
    {
      var sut = new Central();

      sut.Name = "New name";

      var actual = sut.Name;

      Assert.Equal("New name", actual);
    }

  }
}
