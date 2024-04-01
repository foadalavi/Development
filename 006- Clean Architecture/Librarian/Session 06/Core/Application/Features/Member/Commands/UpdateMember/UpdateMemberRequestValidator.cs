using FluentValidation;
using Librarian.Application.Features.Member.Commands._Share;

namespace Librarian.Application.Features.Member.Commands.UpdateMember
{
    public class UpdateMemberRequestValidator : AbstractValidator<UpdateMemberRequest>
    {

        public UpdateMemberRequestValidator()
        {
            RuleFor(t => t.Id)
                .GreaterThanOrEqualTo(1);

            Include(new BaseMemberRequestValidator());
        }
    }
}
