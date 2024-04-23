using ASPnet_2_lab.Abstract;
using ASPnet_2_lab.Models;

namespace ASPnet_2_lab.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private List<Person> _people;
        public PersonRepository()
        {
            _people = new List<Person>() {
                new Person("Mike", "Wizeou", "12-12-2012"),
                new Person("Michelangelo", "Turtle", "03-12-1997"),
                new Person("Bite", "O'eight", "01-05-1987")
            };
        }

        public void AddPerson(Person person) => _people.Add(person);  

        public List<Person> GetPeople() => _people;

        public void RemovePerson(Person person) => _people.Remove(person);
    }
}
