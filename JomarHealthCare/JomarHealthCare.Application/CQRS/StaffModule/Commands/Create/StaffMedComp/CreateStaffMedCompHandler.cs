using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffMedCompHandler : IRequestHandler<CreateStaffMedCompCommand, StaffMedCompDataModel>
    {
        private readonly IStaffMedCompRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateStaffMedCompHandler(IStaffMedCompRepository repo, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<StaffMedCompDataModel> Handle(CreateStaffMedCompCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffMedComp>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffMedCompDataModel>(created);
        }
    }
}