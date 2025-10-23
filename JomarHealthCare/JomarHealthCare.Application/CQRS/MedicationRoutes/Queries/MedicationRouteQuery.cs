using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.MedicationRoutes.Queries
{
    public class MedicationRouteQuery : IRequest<List<MedicationRoute>>
    {
    }
}
