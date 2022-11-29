using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace FormUI
{
    public class DataAccess
    {
        // create method. Passing the last name and get list of persons
        public List<Person> GetPeople(string lastName)
        {
            // allows us to compile the application while we working on it
            // throw new NotImplementedException();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB"))) // created a new connection to our sql db

            // now inside the below curly braces you can ask for the information from db
            {
               // var output = connection.Query<Person>($"select * from People where LastName = '{lastName}'").ToList();
                var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            } // after curly braces closes - db connection will be closed
        }

        public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                // creating Person class instance
                //Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber };

                // because the insert is expecting one or more records so we need to create a list of person called "people"
                List<Person> people = new List<Person>();
                people.Add(new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });

                // people is the list of person. In each instance of the person I can find 4 properties
                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);
            }
        }
    }
}
