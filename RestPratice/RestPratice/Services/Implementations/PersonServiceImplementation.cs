using RestPratice.Model;

namespace RestPratice.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int _count;

        public Person Create(Person person)
        {
            return person;
        }

        public Person FindById(long id)
        {
            return new Person()
            {
                Id = IncrementAndGet(),
                FirstName = "João",
                LastName = "Dias",
                Address = "Itaocara - Rio de Janeiro - Brasil",
                Gender = "Male"
            };
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }


        public Person Update(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {

        }
        private Person MockPerson(int i)
        {
            return new Person()
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Address = "Some Address" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref _count);
        }

    }
}
