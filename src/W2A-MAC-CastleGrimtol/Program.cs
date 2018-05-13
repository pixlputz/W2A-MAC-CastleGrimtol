using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using W2A_MAC_CastleGrimtol.Services;

namespace W2A_MAC_CastleGrimtol
{

   class Program
   {
      static void Main(string[] args)
      {
         GameService gs = new GameService();

         while (gs.Running)
         {
            gs.DisplayGameIntro();

         }

      }
   }

   public static class Globals
   {
      public static string paddingLeft = "     ";

      public static void Write(string output, bool newline)
      {
         if (newline)
         {
            Console.WriteLine(paddingLeft + output);
         }
         else
         {
            Console.Write(paddingLeft + output);
         }
      }

      public static void BlankLine()
      {
         Write("", true);
      }

      public static void Clear()
      {
         Console.Clear();
      }
   }

}
