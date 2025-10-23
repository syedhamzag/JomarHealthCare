using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffTrainingQuery : IRequest<IQueryable<StaffTraining>>
    {
        public string Id { get; set; }=string.Empty;
    }

}