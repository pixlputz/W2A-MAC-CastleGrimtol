using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Interfaces;

namespace DataLayer.HelperMethods
{
   public class ReturnRoom1Info : IRoomInfo
   {
      public string Id { get; set; }
      public string Name { get; set; }
      public string PersonTitle { get; set; }
      public string PersonMood { get; set; }
      public string Item { get; set; }
      public List<string> Description { get; set; }

      public ReturnRoom1Info(string id, string name, string personTitle, string personMood, string item, List<string> description)
      {
         Id = id;
         Name = name;
         PersonTitle = personTitle;
         PersonMood = personMood;
         Item = item;
         Description = description;
      }
   }

}
