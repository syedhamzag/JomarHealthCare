using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffCompetenceTestHandler : IRequestHandler<CreateStaffCompetenceTestCommand, StaffCompetenceTestDataModel>
    {
        private readonly IStaffCompetenceTestRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateStaffCompetenceTestHandler(IStaffCompetenceTestRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<StaffCompetenceTestDataModel> Handle(CreateStaffCompetenceTestCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffCompetenceTest>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffCompetenceTestDataModel>(created);
        }
    }
}