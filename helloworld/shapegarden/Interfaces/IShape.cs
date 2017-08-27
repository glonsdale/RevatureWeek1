namespace shapegarden.Interfaces
{
  public interface IShape
  {
    int Sides{get;}
    double Perimeter();
    double Area();
  }
}