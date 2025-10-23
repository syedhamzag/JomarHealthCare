using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.MedicationRoutes.Command
{
    public class CreateMedicationRouteCommandHandler : IRequestHandler<CreateMedicationRouteCommand, Domain.Entities.MedicationRoute>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMedicationReouteRepository _medicationRouteRepository;

        public CreateMedicationRouteCommandHandler(
            IUnitOfWork unitOfWork, IMedicationReouteRepository medicationReouteRepository)
        {
            _medicationRouteRepository = medicationReouteRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<MedicationRoute> Handle(CreateMedicationRouteCommand request, CancellationToken cancellationToken)
        {
            var route = new Domain.Entities.MedicationRoute
            {
                RouteName = request.RouteName,
                CompanyId = request.CompanyId,
               
            };

            await _medicationRouteRepository.AddAsync(route, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return route;
        }
    }
}
