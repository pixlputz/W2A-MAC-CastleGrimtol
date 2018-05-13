using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Interfaces
{
   internal class IGameStatus
    {
      //string Title { get; set; }
      //string Version { get; set; }
      //string Developer { get; set; }
      //string DateLastUpdated { get; set; }
      //List<string> Description { get; set; }

      enum Mood { Good, Bad };

      string Room { get; set; }
      Mood PersonMood { get; set; }
      List<Item> Inventory { get; set; }

   }


}
