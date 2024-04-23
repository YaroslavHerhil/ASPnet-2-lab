using ASPnet_2_lab.Abstract;
using ASPnet_2_lab.Models;
using ASPnet_2_lab.Repositories;
using System;
using System.Reflection.PortableExecutable;
using System.Runtime.Versioning;

namespace ASPnet_2_lab.Services
{
    public class PersonService : IPersonService
    {
        public readonly IPersonRepository _repository;

        public PersonService()
        {
            _repository = new PersonRepository();
        }
        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
        }


        public List<Person> GetAllPeople() => _repository.GetPeople();

        public Person GetPersonByName(string name) => _repository.GetPeople().FirstOrDefault(p => p.FirstName == name);


        public void WritePersonToFile(Person person, string file)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(person);
            }
        }
        public void WriteAllPeopleToFile(string file)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                foreach (Person person in _repository.GetPeople())
                {
                    sw.WriteLine(person);
                }
            }
            
        }
        private string ReadUntil(StreamReader sr, string separator)
        {
            string output = "";
            while (sr.Peek() >= 0)
            {
                string nextSymbol = ((char)sr.Read()).ToString();
                if (nextSymbol == separator)
                {
                    break;
                }
                output += nextSymbol;
            }
            return output;
        }

        public List<Person> ReadPeopleFromFile(string file, int size, string separator = "/")
        {
            var listOPeople = new List<Person>();
            using (StreamReader sr = new StreamReader(file))
            {
                for (int i = 0; i < size; i++)
                {
                    string fname = ReadUntil(sr, separator);

                    string lname = ReadUntil(sr, separator);
                    string bdate = ReadUntil(sr, separator);
                    listOPeople.Add(new Person(fname, lname, bdate));

                }

            }

            return listOPeople;
        }

        public void AddPerson(Person person)
        {
            _repository.AddPerson(person);
        }

        public void RemovePerson(Person person)
        {
            _repository.RemovePerson(person);
        }


    }
}
