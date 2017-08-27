using System.Threading;

namespace QATest.src
{
  public class XMRadio
  {
    private XMRadio _instance;
    private XMRadio(){
      _instance = new XMRadio();
    }
    public XMRadio Instance { 
      get
      {
        lock(_instance)
        {
          if (_instance == null)
          {
            _instance = new XMRadio();
          }
        }

        if(_instance == null)
        {
        _instance = new XMRadio();
        }
        return _instance;
      }
    }

    public delegate void RadioSignal();
    public event RadioSignal MicHandler;
    public void Broadcast()
    {
      var count=0;
      while(count<6)
      {
        Thread.Sleep(2000);
        System.Console.WriteLine("NOTES! WOO");
        if(MicHandler != null)
        {
          MicHandler();
        }
        count+=1;
      }
      
    }
    
  }
}