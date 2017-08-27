using shapegarden.Interfaces;
using shapegarden.Abstracts;

namespace shapegarden.Models{
  public class Rectangle : AShape
  {
    protected int L2;
    public Rectangle(int b, int h) : base(4, b) {L2 = h;}
    public override double Area(){return L1*L2;}
    public override double Perimeter(){return L1*2 + L2*2;}

    ~Rectangle(){
      //close file;
      //new Square();
    }
  }
}