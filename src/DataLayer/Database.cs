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
         //Build game object:
         game = new Game(
            "New Job, LLC",
            "1.0.0",
            "Michael A. Chamberlain",
            "2018-05-11",
            "Make it through the first day on your new job! - Stay Hired Before You're Fired! "
            );


      }


   }


}
