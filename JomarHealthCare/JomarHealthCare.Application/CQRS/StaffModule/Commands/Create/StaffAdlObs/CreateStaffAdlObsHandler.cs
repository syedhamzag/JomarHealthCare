using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffAdlObsHandler : IRequestHandler<CreateStaffAdlObsCommand, StaffAdlObsDataModel>
    {
        private readonly IStaffAdlObsRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateStaffAdlObsHandler(IStaffAdlObsRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<StaffAdlObsDataModel> Handle(CreateStaffAdlObsCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffAdlObs>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffAdlObsDataModel>(created);
        }
    }




}