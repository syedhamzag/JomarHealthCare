using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateStaffOneToOneHandler : IRequestHandler<UpdateStaffOneToOneCommand, bool>
    {
        private readonly IStaffOneToOneRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateStaffOneToOneHandler(IStaffOneToOneRepository repo, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UpdateStaffOneToOneCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffOneToOne>(request.DataModel);
            _repo.Update(entity);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}