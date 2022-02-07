using Demo.Domain.Models;
using Demo.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Repositories.Implementations
{
    public class PersonRepository : IPersonRepository
    {
        public Task Save(Person person)
        {
            // Lógica para gravar em base de dados 

            return Task.CompletedTask;
        }
    }
}
