using MediatR;
using JomarHealthCare.Application.DataModels.Client;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Client.Commands;

public class CreateClientCommand : IRequest<bool>
{
    public string ProfileImage { get; set; }
    public string Firstname { get; set; }
    public string Middlename { get; set; }
    public string Surname { get; set; }
    public string PreferredName { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string IdNumber { get; set; }
    public string Email { get; set; }
    public DateTime? StartDate { get; set; }
    public int? AreaCodeId { get; set; }
    public int? TerritoryId { get; set; }
    public Guid? CompanyId { get; set; }

    public string ClientManagerId { get; set; }
}

public class DeleteClientCommand : IRequest<bool>
{
    public Guid ClientId { get; set; }
}

public class UpdateClientCommand : IRequest<bool>
{
    public Guid ClientId { get; set; }
    public string Firstname { get; set; }
    public string Middlename { get; set; }
    public string Lastname { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string IDNo { get; set; }
    public string Email { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string AreaCode { get; set; }
    public string Territory { get; set; }
}


public record UpdateClientPersonalInfoCommand(ClientForUpdateDataModel DataModel, Guid Id) : IRequest<ClientForUpdateDataModel>;