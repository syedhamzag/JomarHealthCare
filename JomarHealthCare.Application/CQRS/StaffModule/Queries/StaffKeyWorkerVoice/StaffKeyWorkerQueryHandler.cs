using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffKeyWorkerVoiceQueryHandler : IRequestHandler<StaffKeyWorkerVoiceQuery, IQueryable<StaffKeyWorkerVoice>>
    {
        private readonly IStaffKeyWorkerVoiceRepository _repository;

        public StaffKeyWorkerVoiceQueryHandler(IStaffKeyWorkerVoiceRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffKeyWorkerVoice>> Handle(StaffKeyWorkerVoiceQuery request, CancellationToken cancellationToken)
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