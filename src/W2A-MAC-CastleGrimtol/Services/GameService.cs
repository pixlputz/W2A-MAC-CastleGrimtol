using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.Providers;
using W2A_MAC_CastleGrimtol.Utils;


namespace W2A_MAC_CastleGrimtol.Services
{
   public class GameService
   {
      private GameProvider _gp = new GameProvider();

      public bool Running { get; private set; }
      private bool InGame { get; set; }
      private bool InRoom1 { get; set; }
      private bool InRoom1Look { get; set; }
      private bool InRoom1Take { get; set; }
      private bool InRoom1Help { get; set; }
      private Menu MainMenu { get; set; }
      private Menu Room1Menu { get; set; }
      

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

      private void MainMenuSelection()
      {
         Action action = MainMenu.SelectOption();
         if (action != null)
         {
            action.Invoke();
         }
      }

      private void Room1MenuSelection()
      {
         Action action = Room1Menu.SelectOption();
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

      void BuildRoom1Menu()
      {
         Room1Menu = new Menu(
            "Room 1 Menu",
            new List<MenuOption>
            {
               new MenuOption(moRoom1SelectGo, "Go To Next Room"),
               new MenuOption(moRoom1SelectLook, "Look"),
               new MenuOption(moRoom1SelectHelp, "Help"),
               new MenuOption(moRoom1SelectTake, "Take"),
               new MenuOption(moSelectExit, "Quit")
            });
      }

      private void moSelectPlay()
      {
         BuildRoom1Menu();

         Globals.Clear();
         InRoom1 = true;
         while (InRoom1)
         {
            var gamePlayed = _gp.SetGamePlayedStatus(true);
            var roomInfo = _gp.GetRoom1Info();

            Globals.Clear();
            Globals.BlankLine();
            Globals.Write("You have entered the first room...", true);

            //Display Room Objects: Room Name, Room Manager, Manager's Mood, and Room Item:
            Globals.Write("-------------------------------------------------------------", true);
            Globals.Write("|                  " + roomInfo.Name + "                    |", true);
            Globals.Write("|                                                           |", true);
            Globals.Write("|                                                           |", true);
            Globals.Write("|   Office Manager: " + roomInfo.PersonTitle + "              |", true);
            Globals.Write("|   Manager's Mood: " + roomInfo.PersonMood + "                                     |", true);
            Globals.Write("|                                                           |", true);
            Globals.Write("|                                                           |", true);
            Globals.Write("|   Item Available: " + roomInfo.Item + "                      |", true);
            Globals.Write("|                                                           |", true);
            Globals.Write("-------------------------------------------------------------", true);

            //Display Room Feedback:
            Globals.BlankLine();
            foreach (string line in roomInfo.Description)
            {
               Globals.Write(line, true);
            }

            //Display Room Command Options:
            Globals.BlankLine();
            Room1MenuSelection();
         }
      }

      private void moRoom1SelectGo()
      {
         //Globals.Clear();
         //InGame = true;
         //while (InGame)
         //{
         //   var gamePlayed = _gp.SetGamePlayedStatus(true);

         //   Globals.BlankLine();
         //   Globals.Write("Playing Game now...", true);
         //   Globals.BlankLine();
         //   Globals.Write("Press any key to return to Main Menu... > ", false);
         //   Console.Read();
         //   InGame = false;

         //   Globals.Clear();
         //   Globals.BlankLine();
         //   Globals.Write("You have entered the first room...", true);

         //   Display Room Objects:
         //   Globals.Write("------------------------------------------------------------", true);
         //   Globals.Write("|                                                           |", true);
         //   Globals.Write("|                                                           |", true);
         //   Globals.Write("|                                                           |", true);
         //   Globals.Write("|                                                           |", true);
         //   Globals.Write("|                                                           |", true);
         //   Globals.Write("|                                                           |", true);
         //   Globals.Write("|                                                           |", true);
         //   Globals.Write("|                                                           |", true);
         //   Globals.Write("------------------------------------------------------------", true);

         //   Display Room Feedback:
         //   Globals.BlankLine();
         //   Globals.Write("Are you ready to play?!", true);
         //   Globals.BlankLine();

         //   Display Room Command Options:

         //   Room1MenuSelection();
      }

      private void moRoom1SelectLook()
      {
         var roomInfo = _gp.GetRoom1Info();
         var playerInfo = _gp.GetPlayerInfo();

         Globals.Clear();
         InRoom1Look = true;
         while (InRoom1Look)
         {
            Globals.BlankLine();
            Globals.Write("You look around the room and notice the following:", true);
            Globals.BlankLine();
            Globals.Write("  - This is the Administration Office.", true);
            Globals.Write("  - Managed by an Admin Clerk.", true);

            if (roomInfo.PersonMood == "Bad")
            {
               Globals.Write("  - The Clerk is in a Bad mood. Don't want to disappoint!", true);
            }
            else
            {
               Globals.Write("  - The Clerk is in a Good mood - Yay!", true);
            }

            Globals.BlankLine();
            Globals.Write("You are greeted by the manager of the room:", true);
            foreach (string line in roomInfo.Description)
            {
               Globals.Write(line, true);
            }

            Globals.BlankLine();
            Globals.Write("Your Item Inventory:", true);
            foreach (Item item in playerInfo.Inventory)
            {
               Globals.Write(item.Name, true);
            }

            Globals.BlankLine();
            Globals.Write("Press any key to return to the Administration Office... > ", false);
            Console.Read();
            InRoom1Look = false;
         }
      }

      private void moRoom1SelectHelp()
      {
         var roomInfo = _gp.GetRoom1Info();

         Globals.Clear();
         InRoom1Help = true;
         while (InRoom1Help)
         {
            Globals.BlankLine();
            Globals.Write("Intent is to Take the Item available in the room, Complete it,", true);
            Globals.Write("then Submit it back to the Clerk", true);
            Globals.Write("Be careful! If you do not Complete the item before", true);
            Globals.Write("Submitting it back, you may be fired!", true);

            Globals.BlankLine();
            Globals.Write("Press any key to return to the Administration Office... > ", false);
            Console.Read();
            InRoom1Help = false;
         }
      }

      private void moRoom1SelectTake()
      {
         Globals.Clear();
         InRoom1Take = true;
         while (InRoom1Take)
         {
            //Player Takes Item and adds to Inventory:
            _gp.AddRoom1ItemToInventory();

            Globals.Write("You have just accepted the item offered in this room.", true);
            Globals.Write("Press any key to continue... > ", false);
            Console.Read();
            InRoom1Take = false;
         }

      }

      private void moSelectExit()
      {
         var gamePlayed = _gp.GetGamePlayedStatus();


         Globals.Clear();
         Globals.BlankLine();
         if (gamePlayed.Played)
         {
            Globals.Write("Sorry to see you go; thank you for playing!", true);
         }
         else
         {
            Globals.Write("Too bad you'd rather not play; maybe next time!", true);
         }

         Globals.BlankLine();
         Globals.Write("Exiting Game ...", true);
         Globals.Write("Press any key to continue... > ", false);
         Console.Read();
         InRoom1 = false;
         Running = false;
      }


   }


}
