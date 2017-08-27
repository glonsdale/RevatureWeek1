using Xunit;
using TodoApp.src;

namespace TodoApp.test
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
      //Todo already contains Flank at index 0 from the previous test.
      var expected = "Flank";

      //act
      var actual = Todo.Read(0);
      //assert
      Assert.True(actual == expected);

    }
    [Fact]
    public void UpdateTest()
    {
      //arrange
      var expected = "Prone";
      //act
      var actual = Todo.Update(0, "Prone");

      //assert
      Assert.True(expected == actual);
      
    }
    [Fact]
    public void DeleteTest()
    {
      //arrange
      
      
      var actual = Todo.Delete(0);
      //assert
      Assert.True(actual);
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

