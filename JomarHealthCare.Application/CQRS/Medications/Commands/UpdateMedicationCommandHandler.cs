using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Medications.Commands
{
    public class UpdateMedicationCommandHandler : IRequestHandler<UpdateMedicationCommand, bool>
    {
        private readonly IMedicationRepository _medicationRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserIdentityService _userIdentityService;
        public UpdateMedicationCommandHandler(IMedicationRepository medicationRepository,
            IUnitOfWork unitOfWork, IUserIdentityService userIdentityService)
        {
            _medicationRepository = medicationRepository;
            _unitOfWork = unitOfWork;
            _userIdentityService = userIdentityService;
        }
        public async Task<bool> Handle(UpdateMedicationCommand request, CancellationToken cancellationToken)
        {
            var medication = await _medicationRepository.GetByKeyAsync(new object[] { request.MedicationId }, cancellationToken);
            if (medication == null) return false;

            medication.MedicationName = request.MedicationName;
            medication.Indication = request.Indication;
            medication.Strength = request.Strength;
            medication.CreatedBy = _userIdentityService.CompanyId;
            _medicationRepository.Update(medication);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
