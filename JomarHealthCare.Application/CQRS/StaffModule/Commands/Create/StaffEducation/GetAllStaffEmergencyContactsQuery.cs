using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record GetAllStaffEmergencyContactsQuery : IRequest<IQueryable<StaffEmergencyContact>>;
}