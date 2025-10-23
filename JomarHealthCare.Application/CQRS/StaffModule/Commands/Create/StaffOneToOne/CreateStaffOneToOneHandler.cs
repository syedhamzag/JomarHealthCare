using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffOneToOneHandler : IRequestHandler<CreateStaffOneToOneCommand, StaffOneToOneDataModel>
    {
        private readonly IStaffOneToOneRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateStaffOneToOneHandler(IStaffOneToOneRepository repo, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<StaffOneToOneDataModel> Handle(CreateStaffOneToOneCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffOneToOne>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffOneToOneDataModel>(created);
        }
    }
}