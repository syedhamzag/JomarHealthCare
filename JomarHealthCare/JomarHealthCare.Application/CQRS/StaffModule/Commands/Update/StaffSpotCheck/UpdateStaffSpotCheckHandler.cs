using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands
{
    public class UpdateStaffSpotCheckHandler : IRequestHandler<UpdateStaffSpotCheckCommand, bool>
    {
        private readonly IStaffSpotCheckRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UpdateStaffSpotCheckHandler(IStaffSpotCheckRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(UpdateStaffSpotCheckCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffSpotCheck>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
