using Demo.Domain.Behaviors;
using Demo.Domain.Commands;
using Demo.Domain.Models;
using Demo.Domain.Repositories.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Domain.Handlers
{
    class CreatePersonHandler : IRequestHandler<CreatePerson, Response>
    {
        private readonly IPersonRepository _repository;

        public CreatePersonHandler(IPersonRepository repository)
        {
            _repository = repository;
        }

        public async Task<Response> Handle(CreatePerson request, CancellationToken cancellationToken)
        {
            var person = new Person(request.Name);

            await _repository.Save(person);

            return new Response("Registro criado com sucesso");
        }
    }
}
