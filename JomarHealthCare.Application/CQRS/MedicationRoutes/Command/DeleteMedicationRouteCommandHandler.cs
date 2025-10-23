using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.MedicationRoutes.Command
{
    public class DeleteMedicationRouteCommandHandler : IRequestHandler<DeleteMedicationRouteCommand, bool>
    {
        private readonly IMedicationReouteRepository _medicationRouteRepository;
        private readonly IUnitOfWork _unitOfWork;
        public DeleteMedicationRouteCommandHandler(IMedicationReouteRepository medicationRouteRepository,
            IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _medicationRouteRepository = medicationRouteRepository;
        }
        public async Task<bool> Handle(DeleteMedicationRouteCommand request, CancellationToken cancellationToken)
        {
            var client = await _medicationRouteRepository.GetByKeyAsync(new object[] { request.MedicationRouteId }, cancellationToken);
            if (client == null) return false;

            _medicationRouteRepository.Delete(client);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
