using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands
{
    public class CreateStaffSpotCheckHandler : IRequestHandler<CreateStaffSpotCheckCommand, StaffSpotCheckDataModel>
    {
        private readonly IStaffSpotCheckRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateStaffSpotCheckHandler(IStaffSpotCheckRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<StaffSpotCheckDataModel> Handle(CreateStaffSpotCheckCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffSpotCheck>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffSpotCheckDataModel>(created);
        }
    }
}
