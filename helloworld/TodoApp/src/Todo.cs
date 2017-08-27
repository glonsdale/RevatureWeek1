using System;
using System.Collections.Generic;

namespace TodoApp.src
{
    public static class Todo
    {
      private static List<string> Active = new List<string>();
      private static List<string> Deleted = new List<string>();
      private static List<string> Completed = new List<string>();

      public static bool Create(string creation)
      {
        Active.Add(creation);
        return Active.Find(match: c => c == creation) != null;
      }
      
      public static string Read(int index)
      {
        if(index <= Active.Count)
        {
          return Active[index];
        }
        else return "Not Found";
      }

      public static string Update(int index, string update)
      {
        Active[index] = update;
        return Active[index];
      }

      public static bool Delete(int index)
      {
        
        var item = Read(index);
        Deleted.Add(item);
        Active.Remove(item);
        return !Active.Contains(item) && Deleted.Contains(item);
      }



    }
}