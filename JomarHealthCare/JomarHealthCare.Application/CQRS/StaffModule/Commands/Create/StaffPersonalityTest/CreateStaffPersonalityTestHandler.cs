using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffPersonalityTestHandler : IRequestHandler<CreateStaffPersonalityTestCommand, StaffPersonalityTestDataModel>
    {
        private readonly IStaffPersonalityTestRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateStaffPersonalityTestHandler(IStaffPersonalityTestRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<StaffPersonalityTestDataModel> Handle(CreateStaffPersonalityTestCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffPersonalityTest>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffPersonalityTestDataModel>(created);
        }
    }
}