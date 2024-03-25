using MediatR;

namespace Librarian.Application.Features.Commands.CreateMember
{
    public class CreateMemberRequestHandler : IRequestHandler<CreateMemberRequest, int>
    {
        public CreateMemberRequestHandler()
        {
            
        }

        public Task<int> Handle(CreateMemberRequest request, CancellationToken cancellationToken)
        {
            // validating incoming data


            // convert to domain entity data


            // add to database


            // return value
            throw new NotImplementedException();
        }
    }
}
