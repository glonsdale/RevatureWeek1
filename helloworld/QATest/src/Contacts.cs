using System.Collections.Generic;

namespace QATest.src
{
  public static class Contacts
  {
    public static List<Person> pList = new List<Person>();

    
    public static bool Add(Person p)
    {
      try
      {
        pList.Add(p);
        return true;
      }
      catch
      {
        return false;
      }
    }
    public static Person Update(Person changes)
    {
      var co = pList.Find(c=>c.ID==changes.ID);
      if (co!=null)
      {
        co=changes;
      }
      return co;
    }

    public static bool Delete(int ID)
    {
      var re= pList.Find(c=>c.ID == ID);
      try{
      pList.Remove(re);
      return true;
      }
      catch{
        return false;
      } 
    }

    public static List<Person> List()
    {
      return pList;
    }
    
  }
}