using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.MedicationManufacturers.Command
{
    public class DeleteMedicationManufacturerCommandHandler : IRequestHandler<DeleteMedicationManufacturerCommand, bool>
    {
        private readonly IMedicationManufacturerRepository _medicationManufacturerRepository;
        private readonly IUnitOfWork _unitOfWork;
        public DeleteMedicationManufacturerCommandHandler(IMedicationManufacturerRepository medicationManufacturerRepository,
            IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _medicationManufacturerRepository = medicationManufacturerRepository;
        }
        public async Task<bool> Handle(DeleteMedicationManufacturerCommand request, CancellationToken cancellationToken)
        {
            var client = await _medicationManufacturerRepository.GetByKeyAsync(new object[] { request.MedicationManufacturerId }, cancellationToken);
            if (client == null) return false;

            _medicationManufacturerRepository.Delete(client);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
