using System.Threading;

namespace QATest.src
{


  public class Startup
  {
    public static void Main(string[] args)
    {
    //EventStuff();
    //
    //TaskStuff();
    AsyncStuff();
    Thread.Sleep(5000);
    }
    public static void EventStuff()
    {
      var r = XMRadio.Instance;
      var s = new XMSub();
      s.Subscribe(r);
      r.Broadcast();
    }
    public static void ThreadStuff()
    {
      var ap = new AsyncPro();
      ap.ThreadParty();
    }
    public static void TaskStuff()
    {
      var ap = new AsyncPro();
      ap.TaskParty();
    }

    public static async void AsyncStuff()
    {
      var ap = new AsyncPro();
      await ap.ASyncParty();
    
      //Thread.Sleep(5000);
    }

    public static void FactoryOfFactories()
    {
      var n = new ComputerFactory();
      n.Instance<Gaming>();
    }

  }
}

