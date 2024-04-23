using ASPnet_2_lab.Models;

namespace ASPnet_2_lab.Abstract
{
    public interface IPersonService
    {
        public void WritePersonToFile(Person person, string file);
        public List<Person> ReadPeopleFromFile(string file, int size, string separator = "/");

        public Person GetPersonByName(string name);
        public List<Person> GetAllPeople();
        public void AddPerson(Person person);
        public void RemovePerson(Person person);
        public void WriteAllPeopleToFile(string file);
    }
}
