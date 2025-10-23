using MediatR;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public record StaffMatrixQuery(Guid? key=null) : IRequest<List<StaffMatrixDataModel>>;
}
