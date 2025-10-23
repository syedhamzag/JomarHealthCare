using MediatR;

namespace JomarHealthCare.Application.CQRS.Medications.Commands
{
    public class CreateMedicationCommand: IRequest<Domain.Entities.Medication>
    {
        public string? MedicationName { get; set; }
        public string? Strength { get; set; }
        public string? Indication { get; set; }
    }

}
