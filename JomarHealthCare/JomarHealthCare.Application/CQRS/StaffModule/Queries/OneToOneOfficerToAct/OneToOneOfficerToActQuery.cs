using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class OneToOneOfficerToActQuery : IRequest<IQueryable<OneToOneOfficerToAct>>
    {
        public string Id { get; set; } = string.Empty;
    }
}