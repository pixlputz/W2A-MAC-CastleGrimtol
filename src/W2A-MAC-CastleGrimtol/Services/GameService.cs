using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Providers;
using W2A_MAC_CastleGrimtol.Utils;

namespace W2A_MAC_CastleGrimtol.Services
{
   public class GameService
   {
      private GameProvider _gp = new GameProvider();

      public bool Running { get; private set; }
      private bool InGame { get; set; }
      private Menu MainMenu { get; set; }



      public GameService()
      {
         Running = true;
         BuildMainMenu();

      }

      public void DisplayGameIntro()
      {
         var gameInfo = _gp.GetGameInfo();

         Console.Clear();
         Console.WriteLine("");
         Console.WriteLine("Game Title: " + gameInfo.Title);
         Console.WriteLine("Version: v" + gameInfo.Version);
         Console.WriteLine("Developer: " + gameInfo.Developer);
         Console.WriteLine("Last Updated: " + gameInfo.DateLastUpdated);
         Console.WriteLine("");
         Console.WriteLine(gameInfo.Description);

         MainMenuSelection();
      }

      private void DisplayMainMenu()
      {
         var counter = 1;
         foreach (MenuOption option in MainMenu.Options)
         {
            Console.WriteLine($"{counter++} {option.Description}");
         }
      }

      private void MainMenuSelection()
      {
         Action action = MainMenu.SelectOption();
            if (action != null)
            {
               action.Invoke();
         }
      }

      void BuildMainMenu()
      {
         MainMenu = new Menu(
            "Main Menu",
            new List<MenuOption>
            {
               new MenuOption(moSelectPlay, "Play Game!"),
               new MenuOption(moSelectExit, "Exit")            
            });
      }

      private void moSelectPlay()
      {
         Console.Clear();
         InGame = true;
         while (InGame)
         {
            Console.WriteLine("Playing Game now...");
            Console.WriteLine("");
            Console.Write("Press any key to return to Main Menu... > ");
            Console.Read();
            InGame = false;
         }
      }

      private void moSelectExit()
      {
         Console.Clear();
         Console.WriteLine("Exiting Game ...");
         Console.WriteLine("");
         Console.Write("Press any key to continue... > ");
         Console.Read();
         InGame = false;
         Running = false;
      }


   }


}
