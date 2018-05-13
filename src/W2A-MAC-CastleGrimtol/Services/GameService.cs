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

         Globals.Clear();
         Globals.BlankLine();
         Globals.Write("*************************************************", true);
         Globals.Write("*         Welcome to: " + gameInfo.Title + "              *", true);
         Globals.Write("*************************************************", true);
         Globals.Write("         Version: " + gameInfo.Version + "       ", true);
         Globals.Write("         Developer: " + gameInfo.Developer + "       ", true);
         Globals.Write("         Last Update: " + gameInfo.DateLastUpdated + "       ", true);
         Globals.Write("-------------------------------------------------", true);
         Globals.Write("Today's Date/Time: " + DateTime.Now.ToString(), true);
         Globals.Write("", true);
         foreach (string line in gameInfo.Description)
         {
            Globals.Write(line, true);
         }
         Globals.BlankLine();
         Globals.Write("Are you ready to play?!", true);
         Globals.BlankLine();

         MainMenuSelection();
      }


      //private void DisplayMainMenu()
      //{
      //   var counter = 1;
      //   foreach (MenuOption option in MainMenu.Options)
      //   {
      //      Write($"{counter++}) {option.Description}", true);
      //   }
      //}

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
               new MenuOption(moSelectPlay, "Yes, I'm in! - Let's Play!"),
               new MenuOption(moSelectExit, "No, sorry; I think I'd rather not: Exit")            
            });
      }

      private void moSelectPlay()
      {
         Globals.Clear();
         InGame = true;
         while (InGame)
         {
            Globals.BlankLine();
            Globals.Write("Playing Game now...", true);
            Globals.BlankLine();
            Globals.Write("Press any key to return to Main Menu... > ", false);
            Console.Read();
            InGame = false;
         }
      }

      private void moSelectExit()
      {
         Globals.Clear();
         Globals.BlankLine();
         Globals.Write("Exiting Game ...", true);
         Globals.BlankLine();
         Globals.Write("Press any key to continue... > ", false);
         Console.Read();
         InGame = false;
         Running = false;
      }


   }


}
