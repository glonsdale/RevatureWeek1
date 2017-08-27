namespace QATest.src 
{
  public class Newegg 
  {
    
  }

  public class ComputerFactory : Newegg 
  {
    public Computer Instance<T>() where T : Computer, new()
    {
      return new T();
    }
  }

  public class MonitorFactory : Newegg 
  {

  }


}