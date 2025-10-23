using MediatR;

namespace JomarHealthCare.Application.CQRS.Medications.Commands
{
    public class UpdateMedicationCommand: IRequest<bool>
    {
        public int MedicationId { get; set; }
        public string? MedicationName { get; set; }
        public string? Strength { get; set; }
        public string? Indication { get; set; }
    }
}
