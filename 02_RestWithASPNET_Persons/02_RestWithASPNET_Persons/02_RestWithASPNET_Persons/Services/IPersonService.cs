using _02_RestWithASPNET_Persons.Model;

namespace _02_RestWithASPNET_Persons.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
