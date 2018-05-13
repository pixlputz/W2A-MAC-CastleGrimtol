using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using W2A_MAC_CastleGrimtol.Services;

namespace W2A_MAC_CastleGrimtol.Utils
{
   public class Menu
   {
      internal string Name { get; set; }
      internal List<MenuOption> Options { get; set; }

      public Menu(string name, List<MenuOption> options)
      {
         Name = name;
         Options = options;
      }

      void PrintMenuOptions()
      {
         int count = 1;
         foreach (var option in Options)
         {
            Globals.Write($"{count++}) {option.Description}", true);
         }
         Globals.BlankLine();
         Globals.Write("Selection: > ", false);
      }

      public Action SelectOption()
      {
         PrintMenuOptions();
         string input = Console.ReadLine();

         int index = -1;
         bool valid = int.TryParse(input, out index);
         if (!valid || index <= 0 || index > Options.Count)
         {
            Globals.Write("Invalid Selection; please try again.", true);
            return null;
         }
         return Options[index - 1].Action;
      }

   }


}
