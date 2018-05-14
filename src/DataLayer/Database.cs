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
      internal Room roomAdminOffice;
      internal Room roomHROffice;
      internal Room roomDepOffice;
      internal Room roomWorkArea;
      internal Item itemInProcessingForm;
      internal Item itemPolicyAgreementPackage;
      internal Item itemBuildingFob;
      internal Item itemActiveDirectoryAccount;
      internal Player player;

      public Database()
      {
         //Build Game Description:
         List<string> description = new List<string>();
         description.Add("Make it through the first day on your new job!");
         description.Add("Stay Hired Before You're Fired!");

         //Build game object:
         game = new Game(
            "New Job, LLC",
            "1.0.0",
            "Michael A. Chamberlain",
            "2018-05-13",
            description
            );

         //Build Game items:
         itemInProcessingForm = new Item(1, "In-Processing Form", false, false);
         itemPolicyAgreementPackage = new Item(2, "Policy Agreement Package", false, false);
         itemBuildingFob = new Item(3, "Building Fob", false, false);
         itemActiveDirectoryAccount = new Item(4, "Active Directory Account", false, false);

         //Build Player object:
         player = new Models.Player();

         //Build Room Person objects:
         Person personAdminClerk = new Models.Person("Aministration Office Clerk", Person.MoodStatus.Bad);
         Person personHRManager = new Models.Person("Human Resource Manager", Person.MoodStatus.Bad);
         Person personSupervisor = new Models.Person("Department Supervisor", Person.MoodStatus.Bad);
         Person personCoworker = new Models.Person("Coworker", Person.MoodStatus.Bad);

         //Build Room Descriptions:
         List<string> room1Desc = new List<string> {
            "Administration Clerk: 'Welcome to the 'First Job, LLC' company!'",
            "'Take a copy of our In-Processing form and Submit it when complete.'"
         };
         List<string> room2Desc = new List<string> {
            "HR Manager: 'Welcome! Let's review all of our company policies.'",
            "'Take a copy of our Policy Agreement Package and Submit when complete.'"
         };
         List<string> room3Desc = new List<string> {
            "Supervisor: 'So glad you are joining our team!'",
            "'Take this Building Fob and be sure to test it before end-of-day (EOD).'"
         };
         List<string> room4Desc = new List<string> {
            "Coworker: 'Welcome the office man!'",
            "'Lets build your new Active Directory Account before EOD.'"
         };

         //Build Room objects:
         roomAdminOffice = new Models.Room(1, "Administration Office", room1Desc, personAdminClerk, itemInProcessingForm);
         roomHROffice = new Models.Room(2, "Human Resource Office", room2Desc, personHRManager, itemPolicyAgreementPackage);
         roomDepOffice = new Models.Room(3, "Department Supervisor Office", room3Desc, personSupervisor, itemBuildingFob);
         roomWorkArea = new Models.Room(4, "Work Area Office", room4Desc, personCoworker, itemActiveDirectoryAccount);


      }


   }


}
