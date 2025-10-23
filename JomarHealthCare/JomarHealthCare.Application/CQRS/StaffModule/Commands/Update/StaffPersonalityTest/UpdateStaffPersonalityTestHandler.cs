using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateStaffPersonalityTestHandler : IRequestHandler<UpdateStaffPersonalityTestCommand, bool>
    {
        private readonly IStaffPersonalityTestRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UpdateStaffPersonalityTestHandler(IStaffPersonalityTestRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(UpdateStaffPersonalityTestCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffPersonalityTest>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}