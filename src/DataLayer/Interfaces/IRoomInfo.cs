using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    internal interface IRoomInfo
    {
      string Id { get; set; }
      string Name { get; set; }
      string PersonTitle { get; set; }
      string PersonMood { get; set; }
      string Item { get; set; }
      List<string> Description { get; set; }
   }


}



