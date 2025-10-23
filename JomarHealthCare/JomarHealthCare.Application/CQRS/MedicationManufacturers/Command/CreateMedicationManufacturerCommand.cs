using MediatR;

namespace JomarHealthCare.Application.CQRS.MedicationManufacturers.Command
{
    public class CreateMedicationManufacturerCommand: IRequest<Domain.Entities.MedicationManufacturer>
    {
        public string Manufacturer { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
