using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.MedicationManufacturers.Command
{
    public class CreateMedicationManufacturerCommandHandler : IRequestHandler<CreateMedicationManufacturerCommand, Domain.Entities.MedicationManufacturer>
    {

        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMedicationManufacturerRepository _medicationManufacturerRepository;

        public CreateMedicationManufacturerCommandHandler(IUserIdentityService userIdentityService,
            IUnitOfWork unitOfWork, IMedicationManufacturerRepository medicationManufacturerRepository)
        {
            _unitOfWork = unitOfWork;
            _userIdentityService = userIdentityService;
            _medicationManufacturerRepository = medicationManufacturerRepository;
        }
        public async Task<Domain.Entities.MedicationManufacturer> Handle(CreateMedicationManufacturerCommand request, CancellationToken cancellationToken)
        {
            var medicationManufacturer = new Domain.Entities.MedicationManufacturer
            {
                Manufacturer = request.Manufacturer,
                CompanyId = request.CompanyId
            };

            await _medicationManufacturerRepository.AddAsync(medicationManufacturer, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return medicationManufacturer;
        }
    }
}
