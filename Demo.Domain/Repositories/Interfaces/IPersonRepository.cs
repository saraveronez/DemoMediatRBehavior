using Demo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        Task Save(Person person);
    }
}
