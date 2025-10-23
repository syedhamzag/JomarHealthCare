using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateStaffTrainingHandler : IRequestHandler<UpdateStaffTrainingCommand, bool>
    {
        private readonly IStaffTrainingRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UpdateStaffTrainingHandler(IStaffTrainingRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(UpdateStaffTrainingCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffTraining>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}