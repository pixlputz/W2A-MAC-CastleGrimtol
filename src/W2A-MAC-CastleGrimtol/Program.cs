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
}
