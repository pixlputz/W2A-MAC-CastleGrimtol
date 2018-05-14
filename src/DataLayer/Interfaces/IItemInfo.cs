using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Interfaces
{
    internal interface IItemInfo
    {
      string Id { get; set; }
      string Name { get; set; }
      bool Completed { get; set; }
      bool Submitted { get; set; }
   }


}



