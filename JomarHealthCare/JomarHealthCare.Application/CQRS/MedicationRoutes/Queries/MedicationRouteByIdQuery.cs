using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.MedicationRoutes.Queries
{
    public record MedicationRouteByIdQuery(int Id): IRequest<List<MedicationRoute>>;
 
}
