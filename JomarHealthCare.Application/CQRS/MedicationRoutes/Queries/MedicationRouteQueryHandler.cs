using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.MedicationRoutes.Queries
{
    public class MedicationRouteQueryHandler: IRequestHandler<MedicationRouteQuery, List<MedicationRoute>>
    {
        private readonly IMedicationReouteRepository _repository;
        public MedicationRouteQueryHandler(IMedicationReouteRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<MedicationRoute>> Handle(MedicationRouteQuery request, CancellationToken cancellationToken)
        {
            return await _repository.Get().ToListAsync(cancellationToken);
        }
    }
}
