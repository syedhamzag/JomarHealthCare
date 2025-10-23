using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.MedicationManufacturers.Command
{
    public class UpdateMedicationManufacturerCommandHandler : IRequestHandler<UpdateMedicationManufacturerCommand, bool>
    {
        private readonly IMedicationManufacturerRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public UpdateMedicationManufacturerCommandHandler(IUnitOfWork unitOfWork, 
            IMedicationManufacturerRepository medicationManufacturerRepository)
        {
            _unitOfWork = unitOfWork;
            _repository = medicationManufacturerRepository;
        }
        public async Task<bool> Handle(UpdateMedicationManufacturerCommand request, CancellationToken cancellationToken)
        {
            var manufacturer = await _repository.GetByKeyAsync(new object[] { request.MedicationManufacturerId }, cancellationToken);
            if (manufacturer == null) return false;

            manufacturer.Manufacturer  = request.Manufacturer;
            _repository.Update(manufacturer);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
