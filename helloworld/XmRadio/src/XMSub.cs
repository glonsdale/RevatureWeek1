namespace QATest.src
{
  public class XMSub
  {
    public void Subscribe(XMRadio r)
    {
      r.MicHandler += Listening;
    }
    public void UnSubscribe(XMRadio r)
    {
      r.MicHandler -= Listening;
    }
    private void Listening()
    {
      System.Console.WriteLine("smooth jazz rocks!!");
    }

  }
}