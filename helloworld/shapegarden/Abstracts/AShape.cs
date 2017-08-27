using shapegarden.Interfaces; 
namespace shapegarden.Abstracts{
  public abstract class AShape : IShape
  {
    public int Sides { get;}
    public int L1{ get; }
    protected AShape(int S, int D){
      Sides=S;
      L1 = D;
    }

    public virtual double Area()
    {
      throw new System.NotImplementedException();
    }

    public virtual double Perimeter()
    {
      throw new System.NotImplementedException();
    }

  }
}