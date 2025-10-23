using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffRefereeHandler : IRequestHandler<CreateStaffRefereeCommand, StaffRefereeDataModel>
    {
        private readonly IStaffRefereeRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateStaffRefereeHandler(IStaffRefereeRepository repo, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<StaffRefereeDataModel> Handle(CreateStaffRefereeCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffReferee>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffRefereeDataModel>(created);
        }
    }
}