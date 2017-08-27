using System;

namespace concatador
{
    class Program{
    public static String concatadate(String a, String b){
        var L_a = a.Length;
        var L_b = b.Length;
        var total = L_a+L_b;
        var delta = L_a-L_b;
    //  if (delta==0){
    //      for(var i=0; i<total; i+=1){a[i]=a[i]+b[i];}
    //  }   
     return a;
    }
    
        static void Main(string[] args)
        {
            Console.WriteLine(concatadate("abc", "def"));
        }
    }
}
