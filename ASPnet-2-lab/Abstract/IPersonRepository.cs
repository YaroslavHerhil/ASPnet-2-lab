using ASPnet_2_lab.Models;

namespace ASPnet_2_lab.Abstract
{
    public interface IPersonRepository
    {
        public List<Person> GetPeople();
        public void AddPerson(Person person);
        public void RemovePerson(Person person);



    }
}
