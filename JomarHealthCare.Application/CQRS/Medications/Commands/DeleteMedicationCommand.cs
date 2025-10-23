using MediatR;

namespace JomarHealthCare.Application.CQRS.Medications.Commands
{
    public class DeleteMedicationCommand: IRequest<bool>
    {
        public int MedicationId { get; set; }
    }
}
