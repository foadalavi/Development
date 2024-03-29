using Librarian.Application.Contracts.Persistence;
using Librarian.Application.Exceptions;
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
            var validator = new CreateMemberRequestValidator();
            var validationResult = validator.Validate(request);

            if (validationResult.IsValid == false)
            {
                throw new BadRequestException("Something went wrong.",validationResult.ToDictionary());
            }

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
            return itemToAdd.Id;
        }
    }
}
