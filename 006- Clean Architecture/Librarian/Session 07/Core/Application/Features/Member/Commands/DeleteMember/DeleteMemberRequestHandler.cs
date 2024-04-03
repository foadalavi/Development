using Librarian.Application.Contracts.Persistence;
using Librarian.Application.Exceptions;
using MediatR;

namespace Librarian.Application.Features.Member.Commands.DeleteMember
{
    public class DeleteMemberRequestHandler : IRequestHandler<DeleteMemberRequest, Unit>
    {
        private IMemberRepository _repository;

        public DeleteMemberRequestHandler(IMemberRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteMemberRequest request, CancellationToken cancellationToken)
        {
            // retrieve domain entity object
            var item = await _repository.GetByIdAsync(request.Id);

            // verify that record exists
            if (item == null)
            {
                throw new NotFoundException(nameof(item), request.Id.ToString());
            }

            // remove from database
            await _repository.DeleteAsync(item);

            // return value
            return Unit.Value;
        }
    }
}
