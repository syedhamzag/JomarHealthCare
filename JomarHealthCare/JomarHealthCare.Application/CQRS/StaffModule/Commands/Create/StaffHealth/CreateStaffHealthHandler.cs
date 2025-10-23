using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffHealthHandler : IRequestHandler<CreateStaffHealthCommand, StaffHealthDataModel>
    {
        private readonly IStaffHealthRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateStaffHealthHandler(IStaffHealthRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<StaffHealthDataModel> Handle(CreateStaffHealthCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffHealth>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffHealthDataModel>(created);
        }
    }
}