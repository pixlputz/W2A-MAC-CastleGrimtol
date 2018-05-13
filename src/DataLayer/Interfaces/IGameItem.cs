using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    internal interface IGameItem
    {
      string Title { get; set; }
      string Version { get; set; }
      string Developer { get; set; }
      string DateLastUpdated { get; set; }
      List<string> Description { get; set; }
   }


}



