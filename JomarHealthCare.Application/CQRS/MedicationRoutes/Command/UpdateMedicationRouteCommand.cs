using MediatR;

namespace JomarHealthCare.Application.CQRS.MedicationRoutes.Command
{
    public class UpdateMedicationRouteCommand: IRequest<bool>
    {
        public int MedicationRouteId { get; set; }
        public string RouteName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
