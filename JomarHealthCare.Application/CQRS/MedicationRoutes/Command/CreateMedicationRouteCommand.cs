using MediatR;

namespace JomarHealthCare.Application.CQRS.MedicationRoutes.Command
{
    public class CreateMedicationRouteCommand: IRequest<Domain.Entities.MedicationRoute>
    {
        public string RouteName { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
