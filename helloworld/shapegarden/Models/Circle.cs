using System;
using shapegarden.Abstracts;
using shapegarden.Interfaces;

namespace shapegarden.Models
{
  public class Circle : AShape {
    public Circle(int Radius) : base(1, Radius) {}
    
    public override double Area(){return Math.PI * Math.Pow(L1, 2);}
    public override double Perimeter() {return 2* Math.PI*L1;}
  }
}
