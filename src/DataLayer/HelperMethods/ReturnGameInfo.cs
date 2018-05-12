using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Interfaces;

namespace DataLayer.HelperMethods
{
   public class ReturnGameInfo : IGameItem
   {
      public string Title { get; set; }
      public string Version { get; set; }
      public string Developer { get; set; }
      public string DateLastUpdated { get; set; }
      public string Description { get; set; }

      public ReturnGameInfo(string title, string version, string developer, string dateLastUpdated, string description)
      {
         Title = title;
         Version = version;
         Developer = developer;
         DateLastUpdated = dateLastUpdated;
         Description = description;
      }

   }


}
