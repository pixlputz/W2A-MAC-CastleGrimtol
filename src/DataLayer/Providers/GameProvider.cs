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

      public ReturnRoom1Info GetRoom1Info()
      {
         return new ReturnRoom1Info(
            _db.roomAdminOffice.Id.ToString(),
            _db.roomAdminOffice.Name,
            _db.roomAdminOffice.Person.Title,
            _db.roomAdminOffice.Person.Mood.ToString(),
            _db.roomAdminOffice.Item.Name,
            _db.roomAdminOffice.Description
            );
      }

      public void AddRoom1ItemToInventory()
      {
         _db.player.Inventory.Add(_db.itemInProcessingForm);        
      }

      public ReturnPlayerInfo GetPlayerInfo()
      {
         return new ReturnPlayerInfo(
            _db.player.Inventory
            );
      }


   }


}
