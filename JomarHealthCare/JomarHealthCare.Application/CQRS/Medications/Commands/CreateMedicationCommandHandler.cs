using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Medications.Commands
{
    public class CreateMedicationCommandHandler : IRequestHandler<CreateMedicationCommand, Domain.Entities.Medication>
    {
        private readonly IMedicationRepository _medicationRepository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;
        public CreateMedicationCommandHandler(IUnitOfWork unitOfWork, 
            IMedicationRepository medicationRepository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _medicationRepository = medicationRepository;
            _userIdentityService = userIdentityService;
        }
        public async Task<Domain.Entities.Medication> Handle(CreateMedicationCommand request, CancellationToken cancellationToken)
        {
            var companyId = _userIdentityService.CompanyId;
            var medication = new Domain.Entities.Medication
            {
                
                MedicationName = request.MedicationName,
                Strength = request.Strength,
                Indication = request.Indication,
                CreatedBy = _userIdentityService.CompanyId
            };

            await _medicationRepository.AddAsync(medication, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return medication;
        }
    }
}
