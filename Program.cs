using System;

namespace labtwo
{
    class Program
    {
        static void Main(string[] args)
        {
          // variables and data types
          string dog="Douglas";
          int DOB= 21;
          double rat=21.8;
          char let='P';
          bool me=true;
          long births= -9879;
          short deaths= -6587;
          byte age=218;
          decimal bal=6.18M;
          float pie=4.6F;
          Console.WriteLine(dog);
          Console.WriteLine(DOB);
          Console.WriteLine(rat);
          Console.WriteLine(let);
          Console.WriteLine(me);
          Console.WriteLine(births);
          Console.WriteLine(deaths);
          Console.WriteLine(age);
          Console.WriteLine(bal);
          Console.WriteLine(pie);


          //implicit and explicit coversions

          float hgt=6.7F;
          char flin='B';
          Console.WriteLine((int)hgt);
          Console.WriteLine((double)flin);



        
        }
    }
}
