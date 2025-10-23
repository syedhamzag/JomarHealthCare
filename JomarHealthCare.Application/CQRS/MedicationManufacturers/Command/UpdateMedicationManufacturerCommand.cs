using MediatR;

namespace JomarHealthCare.Application.CQRS.MedicationManufacturers.Command
{
    public class UpdateMedicationManufacturerCommand: IRequest<bool>
    {
        public int MedicationManufacturerId { get; set; }
        public string Manufacturer { get; set; }
    }
}
