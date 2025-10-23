using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffSurveyQueryHandler : IRequestHandler<StaffSurveyQuery, IQueryable<StaffSurvey>>
    {
        private readonly IStaffSurveyRepository _repository;

        public StaffSurveyQueryHandler(IStaffSurveyRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffSurvey>> Handle(StaffSurveyQuery request, CancellationToken cancellationToken)
        {
            var key = request.Id;
            if (!string.IsNullOrEmpty(request.Id))
            {
                return _repository.Get(x => x.StaffId.ToString().Trim() == key.ToString().Trim());
            }
            return _repository.Get();
        }
    }
}