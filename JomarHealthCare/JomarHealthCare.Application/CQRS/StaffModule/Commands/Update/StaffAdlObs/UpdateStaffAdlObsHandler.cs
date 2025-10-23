using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateStaffAdlObsHandler : IRequestHandler<UpdateStaffAdlObsCommand, bool>
    {
        private readonly IStaffAdlObsRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UpdateStaffAdlObsHandler(IStaffAdlObsRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(UpdateStaffAdlObsCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffAdlObs>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }




}