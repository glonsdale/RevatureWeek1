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
      



    }
}