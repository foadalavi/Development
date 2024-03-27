using Librarian.Application.Contracts.Persistence;
using MediatR;

namespace Librarian.Application.Features.Member.Commands.CreateMember
{
    public class CreateMemberRequestHandler : IRequestHandler<CreateMemberRequest, int>
    {
        private readonly IMemberRepository _repository;

        public CreateMemberRequestHandler(IMemberRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateMemberRequest request, CancellationToken cancellationToken)
        {
            // validating incoming data


            // convert to domain entity data
            var itemToAdd = new Domain.Member()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Phone = request.Phone,
                Email = request.Email,
                DateOfBirth = request.DateOfBirth,
            };


            // add to database
            await _repository.CreateAsync(itemToAdd);

            // return value
            throw new NotImplementedException();
        }
    }
}
