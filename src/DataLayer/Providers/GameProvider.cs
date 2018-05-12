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





   }


}
