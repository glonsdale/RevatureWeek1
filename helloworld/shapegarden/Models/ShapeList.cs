using System;
using shapegarden.Interfaces;

namespace shapegarden.Models{
  public class ShapeList<T> where T : class, IShape {
    private T[] collection = new T[int.MaxValue];
    private int count=0;
    public void Add(T u){
      collection[count+=1]=u;
    }
    public void Remove(T u){
      T temp;
      foreach (var i in collection)
      {
        
        if(i.Sides == u.Sides)
        {
          temp=i;
          break;
        }
      }
      temp=null;
    }
  }
  public class WorkWithGenerics{
    public void Play(){
      var g = new ShapeList<Rectangle>();
      g.Add(new Rectangle(2,4));
      g.Remove(new Rectangle(2,4));
    }
  }
}