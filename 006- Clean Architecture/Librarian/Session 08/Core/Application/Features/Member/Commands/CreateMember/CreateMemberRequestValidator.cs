using AutoMapper;
using FluentValidation;
using Librarian.Application.Contracts.Persistence;
using Librarian.Application.Features.Member.Commands._Share;

namespace Librarian.Application.Features.Member.Commands.CreateMember
{
    public class CreateMemberRequestValidator : AbstractValidator<CreateMemberRequest>
    {
        private IMapper _mapper;
        private IMemberRepository _repository;

        public CreateMemberRequestValidator(IMapper mapper, IMemberRepository repository)
        {
            _mapper = mapper;
            _repository = repository;

            Include(new BaseMemberRequestValidator());

            RuleFor(t => t)
                .MustAsync(UniqueMember).WithMessage("The member Already exists.");
        }

        private async Task<bool> UniqueMember(CreateMemberRequest request, CancellationToken token)
        {
            var entiry = _mapper.Map<Domain.Member>(request);
            return await _repository.IsMemberUnique(entiry);
        }
    }
}
