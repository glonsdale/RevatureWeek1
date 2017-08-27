
using System;
using QATest.src;
using Xunit;
namespace QATest.test
{
  public class AddressBook
  {

    [Fact]
    public void AddTest()
    {
      //arrange
      var p = new Person("Greg", "Right behind you", 1);

      //act
      var actual = Contacts.Add(p);
      
      //Assert
      Assert.True(actual);
    }
    [Fact]
    public void UpdateTest()
    {
      //arrange
      var expected = new Person("Greg", "Cloud 9", 1);
      //act
      var actual =  Contacts.Update(expected);
      //assert
      Assert.Equal(actual.ID,expected.ID);
      Assert.Equal(actual.Name,expected.Name);
      Assert.Equal(actual.Address,expected.Address);

    }
    [Fact]
    public void DeleteTest()
    {
      //arrange - expect true from assertion
      //act
      var actual = Contacts.Delete(1);
      //Assert
      Assert.True(actual);

    }
    [Fact]
    public void ListTest()
    {
      //arrange
      var expected = Contacts.pList;
      //act
      var actual = Contacts.List();
      //assert
      Assert.True(expected==actual);

    }
    
    public void DisplayTest()
    {
      var p = new Person("A","B", 3);
      p.DisplayName(USFName);
    }
    Func<string, string, string> USFullName = (string f, string l) => {return f + ", " + l;};
    Func<string, string, string> EUFullName = (string f, string l) => {return l + ", " + f;};
    Action<string, string> FullName = (string q, string w) => {  };
    private string USFName(string a, string z)
    {return a+z;}

    

  }
}