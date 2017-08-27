using Xunit;
using TodoApp.src;

namespace Todo.test
{
  public class UnitTesting
  {
    [Fact]
    public void CreateTest()
    {
      //arrange
      //var expected = true;

      //act
      var actual = Todo.Create("Flank");

      //assert
      Assert.True(actual);

    }
    [Fact]
    public void ReadTest()
    {
      //arrange
      //act
      //assert
    }
    [Fact]
    public void UpdateTest()
    {
      //arrange
      //act
      //assert
    }
    [Fact]
    public void DeleteTest()
    {
      //arrange
      //act
      //assert
    }
    [Fact]
    public void CompleteTest()
    {
      //arrange
      //act
      //assert
    }
  }
}

