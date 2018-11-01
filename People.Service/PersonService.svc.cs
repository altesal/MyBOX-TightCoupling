using PeopleViewer.SharedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace People.Service
{
    public class PersonService : IPersonService
    {

        public List<Person> GetPeople() {
            var p = new List<Person>()
            {
                new Person() { FirstName="John", LastName="Koening",
                    StartDate=DateTime.Parse("10/17/1975"), Rating=6 },
                new Person() { FirstName="Dylan", LastName="Hunt",
                    StartDate=DateTime.Parse("10/02/2000"), Rating=7 },
                new Person() { FirstName="John", LastName="Crichton",
                    StartDate=DateTime.Parse("03/19/1999"), Rating=8 },
                new Person() { FirstName="Dave", LastName="Lister",
                    StartDate=DateTime.Parse("02/15/1988"), Rating=9 },
                new Person() { FirstName="John", LastName="Sheridan",
                    StartDate=DateTime.Parse("01/26/1994"), Rating=6 },
                new Person() { FirstName="Dante", LastName="Montana",
                    StartDate=DateTime.Parse("11/01/2000"), Rating=5 },
                new Person() { FirstName="Isaac", LastName="Gampu",
                    StartDate=DateTime.Parse("09/10/1977"), Rating=6 }
            };
            return p;
        }
        public Person GetPerson(string lastName) { }
        public void AddPerson(Person newPerson) { }
        public void UpdatePerson(string lastName, Person updatedPerson) { }
        public void DeletePerson(string lastName) { }
        public void UpdatePeople(List<Person> updatedPeople) { }



    }
}
