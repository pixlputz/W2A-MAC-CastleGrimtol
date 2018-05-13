using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Models
{
   internal class Item
   {
      internal int Id { get; set; }
      internal string Name { get; set; }
      internal bool Completed { get; set; }
      internal bool Submitted { get; set; }


      internal Item(int id, string name, bool completed, bool submitted)
      {
         Id = id;
         Name = name;
         Completed = completed;
         Submitted = submitted;
      }


   }



}
