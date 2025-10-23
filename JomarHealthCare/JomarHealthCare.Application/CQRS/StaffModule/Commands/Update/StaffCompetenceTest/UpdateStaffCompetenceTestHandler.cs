using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateStaffCompetenceTestHandler : IRequestHandler<UpdateStaffCompetenceTestCommand, bool>
    {
        private readonly IStaffCompetenceTestRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UpdateStaffCompetenceTestHandler(IStaffCompetenceTestRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(UpdateStaffCompetenceTestCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffCompetenceTest>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}