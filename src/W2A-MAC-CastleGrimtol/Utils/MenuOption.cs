using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W2A_MAC_CastleGrimtol.Utils
{
   public class MenuOption
   {
      public Action Action { get; set; }
      public string Description { get; set; }

      public MenuOption(Action action, string description)
      {
         Action = action;
         Description = description;

      }

   }
}
