using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using DataLayer.Models;

namespace DataLayer.HelperMethods
{
   public class ReturnItemInfo : IItemInfo
   {
      public string Id { get; set; }
      public string Name { get; set; }
      public bool Completed { get; set; }
      public bool Submitted { get; set; }


      public ReturnItemInfo(string id, string name, bool completed, bool submitted)
      {
         Id = id;
         Name = name;
         Completed = completed;
         Submitted = submitted;
      }
   }

}
