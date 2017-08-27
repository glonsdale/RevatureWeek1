using System;

namespace QATest.src
{
  public class Person
  {
    public string Name {get; set;}
    public string Address {get; set;}
    public int ID {get; set;}
    public Person(string name, string address, int id){
      Name = name;
      Address = address;
      ID = id;
    }

    public delegate string NameFormat(string a, string z); //function
    public delegate void NameFormatBlank(string a, string z); //action
     
    public void DisplayName(NameFormat name)
    {
      System.Console.WriteLine(name(Name, Address));
    }
  }
}