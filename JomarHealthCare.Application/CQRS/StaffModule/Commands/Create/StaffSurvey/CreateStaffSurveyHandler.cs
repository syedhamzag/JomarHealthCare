using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffSurveyHandler : IRequestHandler<CreateStaffSurveyCommand, StaffSurveyDataModel>
    {
        private readonly IStaffSurveyRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateStaffSurveyHandler(IStaffSurveyRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<StaffSurveyDataModel> Handle(CreateStaffSurveyCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffSurvey>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffSurveyDataModel>(created);
        }
    }
}