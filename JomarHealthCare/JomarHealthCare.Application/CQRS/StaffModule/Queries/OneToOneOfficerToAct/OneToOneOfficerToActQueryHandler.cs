using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class OneToOneOfficerToActQueryHandler : IRequestHandler<OneToOneOfficerToActQuery, IQueryable<OneToOneOfficerToAct>>
    {
        private readonly IOneToOneOfficerToActRepository _repository;

        public OneToOneOfficerToActQueryHandler(IOneToOneOfficerToActRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<OneToOneOfficerToAct>> Handle(OneToOneOfficerToActQuery request, CancellationToken cancellationToken)
        {
            var key = request.Id;
            if (!string.IsNullOrEmpty(request.Id))
            {
                return _repository.Get(x => x.StaffPersonalInfoId.ToString().Trim() == key.ToString().Trim());
            }
            return _repository.Get();
        }
    }
}