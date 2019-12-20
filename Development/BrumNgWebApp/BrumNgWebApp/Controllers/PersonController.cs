using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrumNg.DataAccess.Person;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BrumNgWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonDataAccess _personDataAccess;

        public PersonController(IPersonDataAccess personDataAccess)
        {
            _personDataAccess = personDataAccess;
        }

        public bool ReadFromDatabase
        {
            get
            {
                return true;
            }
        }

        [HttpGet("[action]")]
        public IEnumerable<Person> Persons()
        {
            List<Person> persons;
            if (ReadFromDatabase == true)
            {
                persons = this._personDataAccess.GetAllPersons();

            }
            else
            {
                persons = new List<Person>
                {
                    new Person{ Id =1, Age = 21, Name = "Vinay", FavouriteColour = "Green"},
                    new Person{ Id =2, Age = 22, Name = "Gary", FavouriteColour = "Orange"},
                    new Person{ Id =3, Age = 23, Name = "Rob", FavouriteColour = "Blue"},
                    new Person{ Id =4, Age = 24, Name = "Adam", FavouriteColour = "Red"},
                    new Person{ Id =4, Age = 28, Name = "Cherry", FavouriteColour = "Magenta"},
                    new Person{ Id =4, Age = 30, Name = "Pop", FavouriteColour = "Cyan"},
                };

            }

            return persons;
        }
    }
}