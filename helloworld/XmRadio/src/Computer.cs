using System.Collections.Generic;

namespace QATest.src 
{
  public abstract class Computer
  {
    protected List<Hardware> specs = new List<Hardware>();

    protected Computer()
    {
      BuildComputer();
    }

    protected abstract void BuildComputer();
  }

  public class Gaming : Computer
  {
    protected override void BuildComputer()
    {
      specs.Add(new Keyboard());
      specs.Add(new Monitor());
      specs.Add(new Monitor());
      specs.Add(new Hdd());
      specs.Add(new Hdd());
      specs.Add(new Hdd());
      specs.Add(new Hdd());
    }
  }

  public class Business : Computer
  {
    protected override void BuildComputer()
    {
      specs.Add(new Keyboard());
      specs.Add(new Monitor());
      specs.Add(new Hdd());
    }
  }
}