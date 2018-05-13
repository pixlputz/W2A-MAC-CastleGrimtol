using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Models
{
   internal class Person
   {
      internal enum MoodStatus {
         Good,
         Bad
      }

      internal string Title { get; set; }
      internal MoodStatus Mood { get; set; }

      internal Person(string title, MoodStatus mood)
      {
         Title = title;
         Mood = mood;
      }


   }

}
