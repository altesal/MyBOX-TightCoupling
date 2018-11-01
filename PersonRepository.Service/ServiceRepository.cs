using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleViewer.SharedObjects;

namespace PersonRepository.Service
{
    public class ServiceRepository
    {
        PersonServiceClient ServiceProxy = new PersonServiceClient();
        public IEnumerable<Person> GetPeople()
        {
            return ServiceProxy.GetPeople();
        }
        public Person GetPerson(string lastName) { }
        public void AddPerson(Person newPerson) { }
        public void DeletePerson(string lastName) { }
        public void UpdatePeople(IEnumerable<Person> updatedPeople) { }

    }
}
