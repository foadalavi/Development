using AutoMapper;
using Librarian.Application.Contracts.Persistence;
using Librarian.Application.Exceptions;
using MediatR;

namespace Librarian.Application.Features.Member.Commands.UpdateMember
{
    public class UpdateMemberRequestHandler : IRequestHandler<UpdateMemberRequest, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IMemberRepository _repository;

        public UpdateMemberRequestHandler(IMapper mapper, IMemberRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateMemberRequest request, CancellationToken cancellationToken)
        {
            // validating incoming data
            var validator = new UpdateMemberRequestValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any())
            {
                throw new BadRequestException("Something went wrong", validationResult.ToDictionary());
            }

            // get the item to edit form the DataBase
            var itemToEdit = await _repository.GetByIdAsync(request.Id);

            if (itemToEdit is null)
                throw new NotFoundException(nameof(itemToEdit), request.Id.ToString());

            // convert to domain entity data
            _mapper.Map(request, itemToEdit);

            // add to database
            await _repository.UpdateAsync(itemToEdit);

            // return value
            return Unit.Value;
        }
    }
}
