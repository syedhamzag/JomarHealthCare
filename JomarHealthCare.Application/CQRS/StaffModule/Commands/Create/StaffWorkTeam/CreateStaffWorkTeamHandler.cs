using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffWorkTeamHandler : IRequestHandler<CreateStaffWorkTeamCommand, StaffWorkTeamDataModel>
    {
        private readonly IStaffWorkTeamRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly IApplicationUserRepository _applicationUserRepository;


        public CreateStaffWorkTeamHandler(IStaffWorkTeamRepository repo, IMapper mapper, IUnitOfWork uow, IApplicationUserRepository applicationUserRepository)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
            _applicationUserRepository = applicationUserRepository;
        }

        public async Task<StaffWorkTeamDataModel> Handle(CreateStaffWorkTeamCommand request, CancellationToken cancellationToken)
        {
            var user = await _applicationUserRepository.Get(x => x.Id == request.DataModel.CreatedBy).FirstOrDefaultAsync();
            if (user == null)
            {
                throw new ArgumentException($"User with ID {request.DataModel.CreatedBy} not found.");
            }
            var entity = _mapper.Map<StaffWorkTeam>(request.DataModel);
            var result = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffWorkTeamDataModel>(result);
        }
    }
}