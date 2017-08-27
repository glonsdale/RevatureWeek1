using shapegarden.Interfaces;
using shapegarden.Abstracts;

namespace shapegarden.Models
{
  public class Triangle : AShape {
    protected int L2;
    protected int L3;
    public Triangle(int S1, int S2, int S3) : base(3, S1) { L2 = S2; L3 = S3;}
    public override double Area(){ return (L1*L2)/2; }
    public override double Perimeter(){ return L1+L2+L3; }
    }
}