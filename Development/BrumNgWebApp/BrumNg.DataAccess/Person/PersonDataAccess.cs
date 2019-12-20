using BrumNg.DataAccess.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BrumNg.DataAccess.Person
{
    public class PersonDataAccess : DataAccessBase, IPersonDataAccess
    {
        public List<Person> GetAllPersons()
        {
            var readPersons = new Func<SqlDataReader, List<Person>>(ReadAllPersons);

            var persons = PerformDataOperation<List<Person>>("[dbo].[GetAllPersons]", readPersons);

            return persons;
        }

        private static List<Person> ReadAllPersons(SqlDataReader reader)
        {
            List<Person> persons = new List<Person>();

            while (reader.Read())
            {
                var person = ReadSinglePerson(reader);

                persons.Add(person);
            }

            return persons;
        }

        private static Person ReadSinglePerson(SqlDataReader reader)
        {
            var person = new Person
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Age = reader.GetDecimal(2),
                FavouriteColour = reader.GetString(3)
            };
            return person;
        }
    }
}
