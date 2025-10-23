using MediatR;

namespace JomarHealthCare.Application.CQRS.MedicationRoutes.Command
{
    public class DeleteMedicationRouteCommand: IRequest<bool>
    {
        public int MedicationRouteId { get; set; }
    }
}
