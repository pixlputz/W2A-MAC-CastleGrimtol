using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using DataLayer.Models;

namespace DataLayer.HelperMethods
{
   public class ReturnPlayerInfo : IPlayerInfo
   {
      public List<Item> Inventory { get; set; }

      public ReturnPlayerInfo(List<Item> inventory)
      {
         Inventory = inventory;
      }

      public void AddRoom1Item(Item item)
      {
         Inventory.Add(item);
      }

   }

}
