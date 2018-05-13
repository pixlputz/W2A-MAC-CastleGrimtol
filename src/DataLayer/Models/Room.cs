using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Models
{
   internal class Room
    {
      internal int Id { get; set; }
      internal string Name { get; set; }
      internal List<string> Description { get; set; }
      internal Person Person { get; set; }
      internal Item Item { get; set; }

      internal Room(int id, string name, List<string> description, Person person, Item item)
      {
         Id = id;
         Name = name;
         Description = description;
         Person = person;
         Item = item;
      }

   }

}
