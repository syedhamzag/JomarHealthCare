using MediatR;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Domain.Enums;

namespace JomarHealthCare.Application.CQRS.Policy.Commands;

public class CreatePolicyCommand : IRequest<Policies>
{
    public string Name { get; set; }
    public string Ref { get; set; }
    public string PolicyOwner { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? LastReview { get; set; }
    public DateTime? EndDate { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public PolicyType PolicyType { get; set; }
}


public class DeletePolicyCommand : IRequest<bool>
{
    public Guid PolicyId { get; set; }
}

public class UpdatePolicyCommand : IRequest<bool>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Ref { get; set; }
    public string PolicyOwner { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? LastReview { get; set; }
    public DateTime? EndDate { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public PolicyType PolicyType { get; set; }
}
