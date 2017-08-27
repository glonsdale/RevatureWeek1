using System;

namespace helloworld
{
    class exercise1
    {
      static int fizzs=0;
      static int buzzs=0;
      static int fizzbuzzs=0;

        public static void fb(int i)
        {
          if (i%3==0 && i%5==0)
          {fizzbuzzs=fizzbuzzs+1;
          }
          else if(i%3==0 && i%5!=0)
          {fizzs=fizzs+1;}
          else if(i%5==0 && i%3!=0)
          {buzzs=buzzs+1;}
          else return;
        }
        static void Main(string[] args)
        {
          for (int i = 1; i<101; i++){
            fb(i);
          }
            Console.WriteLine("Fizzs: " + fizzs);
            Console.WriteLine("Buzzs: " + buzzs);
            Console.WriteLine("FizzBuzzs: " + fizzbuzzs);
        }
        
    }
}
