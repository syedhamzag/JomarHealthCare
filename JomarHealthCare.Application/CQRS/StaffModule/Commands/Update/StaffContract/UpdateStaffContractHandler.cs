using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateStaffContractHandler : IRequestHandler<UpdateStaffContractCommand, bool>
    {
        private readonly IStaffContractRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UpdateStaffContractHandler(IStaffContractRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(UpdateStaffContractCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffContract>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}