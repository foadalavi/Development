using AutoMapper;
using Librarian.Application.Contracts.Persistence;
using Librarian.Application.Exceptions;
using MediatR;

namespace Librarian.Application.Features.Member.Commands.CreateMember
{
    public class CreateMemberRequestHandler : IRequestHandler<CreateMemberRequest, int>
    {
        private readonly IMapper _mapper;
        private readonly IMemberRepository _repository;

        public CreateMemberRequestHandler(IMapper mapper, IMemberRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<int> Handle(CreateMemberRequest request, CancellationToken cancellationToken)
        {
            // validating incoming data
            var validator = new CreateMemberRequestValidator(_mapper,_repository);
            var validationResult = validator.Validate(request);

            if (validationResult.IsValid == false)
            {
                throw new BadRequestException("Something went wrong.",validationResult.ToDictionary());
            }

            // convert to domain entity data
            var itemToAdd = _mapper.Map<Domain.Member>(request);

            // add to database
            await _repository.CreateAsync(itemToAdd);

            // return value
            return itemToAdd.Id;
        }
    }
}
