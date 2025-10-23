using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateCandidateInterviewHandler : IRequestHandler<CreateCandidateInterviewCommand, CandidateInterviewDataModel>
    {
        private readonly ICandidateInterviewRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateCandidateInterviewHandler(ICandidateInterviewRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<CandidateInterviewDataModel> Handle(CreateCandidateInterviewCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<CandidateInterview>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<CandidateInterviewDataModel>(created);
        }
    }
}
