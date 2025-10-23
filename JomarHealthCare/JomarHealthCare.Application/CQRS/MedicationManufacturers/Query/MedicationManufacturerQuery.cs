using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.MedicationManufacturers.Query
{
    public class MedicationManufacturerQuery: IRequest<List<MedicationManufacturer>>
    {

    }
}
