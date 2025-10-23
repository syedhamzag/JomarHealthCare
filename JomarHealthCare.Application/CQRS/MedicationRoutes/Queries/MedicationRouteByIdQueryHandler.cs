using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.MedicationRoutes.Queries
{
    public class MedicationRouteByIdQueryHandler : IRequestHandler<MedicationRouteByIdQuery, List<MedicationRoute?>>
    {
        private readonly IMedicationReouteRepository _repository;

        public MedicationRouteByIdQueryHandler(IMedicationReouteRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<MedicationRoute>> Handle(MedicationRouteByIdQuery request, CancellationToken cancellationToken)
        {

            var entities = await _repository.Get().Where(x => x.MedicationRoutId == request.Id).ToListAsync();

            return entities.Select(entity => new MedicationRoute
            {
                MedicationRoutId = entity.MedicationRoutId,
                RouteName = entity.RouteName,

            }).ToList();
        }
    }
}
