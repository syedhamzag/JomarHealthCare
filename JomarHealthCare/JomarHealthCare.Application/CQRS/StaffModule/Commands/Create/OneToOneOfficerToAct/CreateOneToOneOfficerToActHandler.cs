using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateOneToOneOfficerToActHandler : IRequestHandler<CreateOneToOneOfficerToActCommand, OneToOneOfficerToActDataModel>
    {
        private readonly IOneToOneOfficerToActRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateOneToOneOfficerToActHandler(IOneToOneOfficerToActRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<OneToOneOfficerToActDataModel> Handle(CreateOneToOneOfficerToActCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<OneToOneOfficerToAct>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<OneToOneOfficerToActDataModel>(created);
        }
    }
}