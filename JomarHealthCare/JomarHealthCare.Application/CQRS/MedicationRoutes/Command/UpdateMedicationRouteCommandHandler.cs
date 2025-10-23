using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.MedicationRoutes.Command
{
    public class UpdateMedicationRouteCommandHandler: IRequestHandler<UpdateMedicationRouteCommand, bool>
    {
        private readonly IMedicationReouteRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public UpdateMedicationRouteCommandHandler(IUnitOfWork unitOfWork,
            IMedicationReouteRepository medicationManufacturerRepository)
        {
            _unitOfWork = unitOfWork;
            _repository = medicationManufacturerRepository;
        }
        public async Task<bool> Handle(UpdateMedicationRouteCommand request, CancellationToken cancellationToken)
        {
            var route = await _repository.GetByKeyAsync(new object[] { request.MedicationRouteId }, cancellationToken);
            if (route == null) return false;

            route.RouteName = request.RouteName;
            _repository.Update(route);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
