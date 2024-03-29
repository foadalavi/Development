using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Application.Features.Member.Commands.CreateMember
{
    public class CreateMemberRequestValidator :AbstractValidator<CreateMemberRequest>
    {
        public CreateMemberRequestValidator()
        {
            RuleFor(t => t.FirstName)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(50).WithMessage("{PropertyName} must be fewer than 50 characters.");

            RuleFor(t => t.LastName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must be fewer than 50 characters.");

            RuleFor(t => t.Email)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must be fewer than 50 characters.")
                .EmailAddress().WithMessage("{PropertyName} must have a correct email format.");

            RuleFor(t => t.Phone)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(12).WithMessage("{PropertyName} must be fewer than 12 characters.");

            RuleFor(t => t.PostalCode)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .Length(7).WithMessage("{PropertyName} must be 7 characters.");
        }
    }
}
