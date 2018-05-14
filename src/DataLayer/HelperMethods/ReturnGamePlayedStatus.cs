using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Interfaces;

namespace DataLayer.HelperMethods
{
   public class ReturnGamePlayedStatus : IGamePlayedStatus
   {
      public bool Played { get; set; }

      public ReturnGamePlayedStatus(bool played)
      {
         Played = played;
      }
   }

}
