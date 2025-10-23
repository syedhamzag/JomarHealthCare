using MediatR;

namespace JomarHealthCare.Application.CQRS.MedicationManufacturers.Command
{
    public class DeleteMedicationManufacturerCommand: IRequest<bool>
    {
        public int MedicationManufacturerId { get; set; }
    }
}
