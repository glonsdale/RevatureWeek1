using System;
using shapegarden.Abstracts;
using shapegarden.Interfaces;
using shapegarden.Models;

namespace shapegarden
{
    class Program //internal
    {
        static AShape a1 = new Square(2);
        static AShape a2 = new Circle(2);
        static AShape a3 = new Rectangle(2,4);
        static AShape a4 = new Triangle(3,4,5);
        static void Main(string[] args) //private
        {
            PlayWithShapes(a1, a2, a3, a4);
        }
        public static void PlayWithShapes(params IShape[] r){
            try{
                foreach(var item in r)
                {
                
                Console.WriteLine("Area:" + item.Area()+"\n");
                Console.WriteLine("Perimeter:" + item.Perimeter()+"\n");
                }
            }
            catch(NullReferenceException ex){
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex){
                //throw ex;// goes to line 30
                throw new Exception("message",ex); //goes back up to error source
            }
            finally{
                GC.Collect();
            }
        }
    }
}
