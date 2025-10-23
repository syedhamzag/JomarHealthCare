using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffShadowingHandler : IRequestHandler<CreateStaffShadowingCommand, StaffShadowingDataModel>
    {
        private readonly IStaffShadowingRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateStaffShadowingHandler(IStaffShadowingRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<StaffShadowingDataModel> Handle(CreateStaffShadowingCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffShadowing>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffShadowingDataModel>(created);
        }
    }
}