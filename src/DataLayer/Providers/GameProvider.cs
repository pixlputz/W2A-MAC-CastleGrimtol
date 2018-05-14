using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.Interfaces;
using DataLayer.HelperMethods;

namespace DataLayer.Providers
{

   public class GameProvider
   {
      private Database _db;

      public GameProvider()
      {
         _db = new Database();
      }

      public ReturnGameInfo GetGameInfo()
      {
         return new ReturnGameInfo(
            _db.game.Title,
            _db.game.Version,
            _db.game.Developer,
            _db.game.DateLastUpdated,
            _db.game.Description
            );
      }

      public ReturnGamePlayedStatus GetGamePlayedStatus()
      {
         return new ReturnGamePlayedStatus(_db.game.Played);
      }

      public ReturnGamePlayedStatus SetGamePlayedStatus(bool played)
      {
         return new ReturnGamePlayedStatus(_db.game.Played = true);
      }

      public ReturnRoomInfo GetRoom1Info()
      {
         return new ReturnRoomInfo(
            _db.roomAdminOffice.Id.ToString(),
            _db.roomAdminOffice.Name,
            _db.roomAdminOffice.Person.Title,
            _db.roomAdminOffice.Person.Mood.ToString(),
            _db.roomAdminOffice.Item.Name,
            _db.roomAdminOffice.Description
            );
      }

      public ReturnRoomInfo GetRoom2Info()
      {
         return new ReturnRoomInfo(
            _db.roomHROffice.Id.ToString(),
            _db.roomHROffice.Name,
            _db.roomHROffice.Person.Title,
            _db.roomHROffice.Person.Mood.ToString(),
            _db.roomHROffice.Item.Name,
            _db.roomHROffice.Description
            );
      }

      public ReturnRoomInfo GetRoom3Info()
      {
         return new ReturnRoomInfo(
            _db.roomDepOffice.Id.ToString(),
            _db.roomDepOffice.Name,
            _db.roomDepOffice.Person.Title,
            _db.roomDepOffice.Person.Mood.ToString(),
            _db.roomDepOffice.Item.Name,
            _db.roomDepOffice.Description
            );
      }

      public ReturnRoomInfo GetRoom4Info()
      {
         return new ReturnRoomInfo(
            _db.roomWorkArea.Id.ToString(),
            _db.roomWorkArea.Name,
            _db.roomWorkArea.Person.Title,
            _db.roomWorkArea.Person.Mood.ToString(),
            _db.roomWorkArea.Item.Name,
            _db.roomWorkArea.Description
            );
      }

      public void AddRoom1ItemToInventory()
      {
         _db.player.Inventory.Add(_db.itemInProcessingForm);
      }

      public void AddRoom2ItemToInventory()
      {
         _db.player.Inventory.Add(_db.itemPolicyAgreementPackage);
      }

      public void AddRoom3ItemToInventory()
      {
         _db.player.Inventory.Add(_db.itemBuildingFob);
      }

      public void AddRoom4ItemToInventory()
      {
         _db.player.Inventory.Add(_db.itemActiveDirectoryAccount);
      }

      public void CompleteRoom1Item()
      {
         _db.itemInProcessingForm.Completed = true;
      }

      public void CompleteRoom2Item()
      {
         _db.itemPolicyAgreementPackage.Completed = true;
      }

      public void CompleteRoom3Item()
      {
         _db.itemBuildingFob.Completed = true;
      }

      public void CompleteRoom4Item()
      {
         _db.itemActiveDirectoryAccount.Completed = true;
      }

      public void SubmitRoom1Item()
      {
         _db.itemInProcessingForm.Submitted = true;
      }

      public void SubmitRoom2Item()
      {
         _db.itemPolicyAgreementPackage.Submitted = true;
      }

      public void SubmitRoom3Item()
      {
         _db.itemBuildingFob.Submitted = true;
      }

      public void SubmitRoom4Item()
      {
         _db.itemActiveDirectoryAccount.Submitted = true;
      }


      public ReturnPlayerInfo GetPlayerInfo()
      {
         return new ReturnPlayerInfo(
            _db.player.Inventory
            );
      }

      public ReturnItemInfo GetItemInfo(Item item)
      {
         return new ReturnItemInfo(item.Id.ToString(), item.Name, item.Completed, item.Submitted);
      }

      public void Restart()
      {
         _db = new Database();
      }

      public void SetRoom2PersonMood(string mood)
      {
         if (mood == "Good")
         {
            _db.roomHROffice.Person.Mood = Person.MoodStatus.Good;
         }
         else
         {
            _db.roomHROffice.Person.Mood = Person.MoodStatus.Bad;
         }
      }

      public void SetRoom3PersonMood(string mood)
      {
         if (mood == "Good")
         {
            _db.roomDepOffice.Person.Mood = Person.MoodStatus.Good;
         }
         else
         {
            _db.roomDepOffice.Person.Mood = Person.MoodStatus.Bad;
         }
      }

      public void SetRoom4PersonMood(string mood)
      {
         if (mood == "Good")
         {
            _db.roomWorkArea.Person.Mood = Person.MoodStatus.Good;
         }
         else
         {
            _db.roomWorkArea.Person.Mood = Person.MoodStatus.Bad;
         }
      }



   }


}
