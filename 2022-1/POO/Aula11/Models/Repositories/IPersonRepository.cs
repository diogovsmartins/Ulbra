using System.Collections.Generic;
using Aula11.Models.Domains;

namespace Aula11.Models.Repositories
{
    public interface IPersonRepository
    {
        Person GetById(int id);
        List<Person> GetAll();
        void Create(Person person);
        void Update(Person person);
        void Delete(int id);
    }
}