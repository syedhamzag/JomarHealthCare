using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateOneToOneOfficerToActHandler : IRequestHandler<UpdateOneToOneOfficerToActCommand, bool>
    {
        private readonly IOneToOneOfficerToActRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UpdateOneToOneOfficerToActHandler(IOneToOneOfficerToActRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(UpdateOneToOneOfficerToActCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<OneToOneOfficerToAct>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}