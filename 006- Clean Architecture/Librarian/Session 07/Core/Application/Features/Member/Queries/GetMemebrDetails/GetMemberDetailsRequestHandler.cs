using AutoMapper;
using Librarian.Application.Contracts.Persistence;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Application.Features.Member.Queries.GetMemebrDetails
{
    public class GetMemberDetailsRequestHandler : IRequestHandler<GetMemberDetailsRequest, MemberDetailsDto>
    {

        private readonly IMapper _mapper;
        private readonly IMemberRepository _repository;

        public GetMemberDetailsRequestHandler(IMapper mapper, IMemberRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<MemberDetailsDto> Handle(GetMemberDetailsRequest request, CancellationToken cancellationToken)
        {
            // Query the database
            var members = await _repository.GetByIdAsync(request.Id);

            // convert to DTO objects
            var result = _mapper.Map<MemberDetailsDto>(members);

            // return value
            return result;
        }
    }
}
