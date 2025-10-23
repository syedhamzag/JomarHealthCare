using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.ReportedConcerns.Commands
{
    public class UpdateReportedConcernHandler : IRequestHandler<UpdateReportedConcernCommand, bool>
    {
        private readonly IReportedConcernRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UpdateReportedConcernHandler(IReportedConcernRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(UpdateReportedConcernCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<ReportedConcern>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}