using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Person
    {
        // add properties that mathces columns of data in table "dbo.People". This will capture rows from the table
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
      
        public string FullInfo
        {
            get 
            {
                // this will return user in a form like : Tim Corey (email@email)
                return $"{FirstName}, {LastName } ({EmailAddress})";
 
            }
          
        }


    }
}
