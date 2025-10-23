using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffEmergencyContactQuery : IRequest<IQueryable<StaffEmergencyContact>>
    {
        public string Id { get; set; } = string.Empty;
    }
}