using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class ClassOfStaffQueryHandler : IRequestHandler<ClassOfStaffQuery, IQueryable<ClassOfStaff>>
    {
        private readonly IClassOfStaffRepository _repository;

        public ClassOfStaffQueryHandler(IClassOfStaffRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<ClassOfStaff>> Handle(ClassOfStaffQuery request, CancellationToken cancellationToken)
        {
            var key = request.Id;
            if (!string.IsNullOrEmpty(request.Id))
            {
                return _repository.Get(x => x.Id.ToString().Trim() == key.ToString().Trim());
            }
            return _repository.Get();
        }
    }
}