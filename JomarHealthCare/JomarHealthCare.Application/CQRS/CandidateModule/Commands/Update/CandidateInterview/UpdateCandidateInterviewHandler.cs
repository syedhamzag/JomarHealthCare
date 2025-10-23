using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateCandidateInterviewHandler : IRequestHandler<UpdateCandidateInterviewCommand, bool>
    {
        private readonly ICandidateInterviewRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UpdateCandidateInterviewHandler(ICandidateInterviewRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(UpdateCandidateInterviewCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<CandidateInterview>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
