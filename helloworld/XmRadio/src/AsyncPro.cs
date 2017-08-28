using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace QATest.src
{
  public class AsyncPro
  {
    private Dictionary<string, string> TStatus = new Dictionary<string, string>();
    public void ThreadParty()
    {
       
      var t1 = new Thread(()=> {
        DoSomething("t1", "A");
      });
      var t2 = new Thread(() => {
        DoSomething("t2","B");
      });

      t1.Start();
      t2.Start();
      DoSomething("t0","1");

      // if (t1.isAlive)
      // {

      // }
      t1.Join();
      t2.Join();

      foreach(var item in TStatus)
      {
        System.Console.WriteLine("\n{0}: {1}", item.Key, item.Value);
      }
    }
    public Task ASyncParty()
    {
      return Task.Run(()=>{
      T1Async().Start();
      T2Async().Start();
      DoSomething("t0", "0");
      });
    }
    private Task T1Async(){
      return new Task(()=> {
        DoSomething("t1", "A");
      });
    }
    private Task T2Async(){
      return new Task(()=> {
        DoSomething("t2", "B");
      });
    }
    

    private void DoSomething(string t, string s)
    {
      for (var x=0; x<10; x+=1)
      {
        System.Console.Write(s);
      }
      TStatus[t] = "done";
    }
    public void TaskParty()
    {
      var t1 = new Task(()=> {
        DoSomething("t1", "A");
      });
      var t2 = new Task(() => {
        DoSomething("t2","B");
      });

      DoSomething("t0", "0");

      t1.Start();
      t2.Start();
      //Task.WaitAny(t1,t2); //wait for the first one to complete
      Task.WaitAll(t1,t2);// wait for the last one to complete

      foreach(var item in TStatus)
      {
        System.Console.Write("\n{0}: {1} \n", item.Key, item.Value);
      }
    }
  }
}
