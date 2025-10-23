using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffContractHandler : IRequestHandler<CreateStaffContractCommand, StaffContractDataModel>
    {
        private readonly IStaffContractRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateStaffContractHandler(IStaffContractRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<StaffContractDataModel> Handle(CreateStaffContractCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffContract>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffContractDataModel>(created);
        }
    }
}