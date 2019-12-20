using System.Collections.Generic;

namespace BrumNg.DataAccess.Person
{
    public interface IPersonDataAccess
    {
        List<Person> GetAllPersons();
    }
}