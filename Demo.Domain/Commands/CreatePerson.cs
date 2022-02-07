using Demo.Domain.Behaviors;
using MediatR;

namespace Demo.Domain.Commands
{
    public class CreatePerson : IRequest<Response>
    {
        public string Name { get; }

        public CreatePerson(string name)
        {
            Name = name;
        }
    }
}
