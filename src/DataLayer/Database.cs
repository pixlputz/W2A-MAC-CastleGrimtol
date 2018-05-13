using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
   internal class Database
   {
      internal Game game;

      public Database()
      {
         List<string> description = new List<string>();
         description.Add("Make it through the first day on your new job!");
         description.Add("Stay Hired Before You're Fired!");

         //Build game object:
         game = new Game(
            "New Job, LLC",
            "1.0.0",
            "Michael A. Chamberlain",
            "2018-05-11",
            description
            );


      }


   }


}
