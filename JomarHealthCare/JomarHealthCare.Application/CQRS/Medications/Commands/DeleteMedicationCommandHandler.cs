using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Medications.Commands
{
    public class DeleteMedicationCommandHandler : IRequestHandler<DeleteMedicationCommand, bool>
    {
        private readonly IMedicationRepository _medicationRepository;
        private readonly IUnitOfWork _unitOfWork;
        public DeleteMedicationCommandHandler(IMedicationRepository medicationRepository, IUnitOfWork unitOfWork)
        {
            _medicationRepository = medicationRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(DeleteMedicationCommand request, CancellationToken cancellationToken)
        {
            var client = await _medicationRepository.GetByKeyAsync(new object[] { request.MedicationId }, cancellationToken);
            if (client == null) return false;

            _medicationRepository.Delete(client);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
