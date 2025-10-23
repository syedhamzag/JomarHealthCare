using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateStaffMedCompHandler : IRequestHandler<UpdateStaffMedCompCommand, bool>
    {
        private readonly IStaffMedCompRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateStaffMedCompHandler(IStaffMedCompRepository repo, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UpdateStaffMedCompCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffMedComp>(request.DataModel);
            _repo.Update(entity);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}