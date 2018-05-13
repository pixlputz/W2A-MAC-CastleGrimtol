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

      private string paddingLeft = "     ";



      public GameService()
      {
         Running = true;
         BuildMainMenu();

      }

      public void DisplayGameIntro()
      {
         var gameInfo = _gp.GetGameInfo();

         Clear();
         BlankLine();
         Write("*************************************************", true);
         Write("*         Welcome to: " + gameInfo.Title + "              *", true);
         Write("*************************************************", true);
         Write("         Version: " + gameInfo.Version + "       ", true);
         Write("         Developer: " + gameInfo.Developer + "       ", true);
         Write("         Last Update: " + gameInfo.DateLastUpdated + "       ", true);
         Write("-------------------------------------------------", true);
         Write("Today's Date/Time: " + DateTime.Now.ToString(), true);
         Write("", true);
         foreach (string line in gameInfo.Description)
         {
            Write(line, true);
         }
         BlankLine();
         Write("Are you ready to play?!", true);
         BlankLine();

         MainMenuSelection();
      }

      public void Write(string output, bool newline)
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

      public void BlankLine()
      {
         Write("", true);
      }

      public void Clear()
      {
         Console.Clear();
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
