using MediatR;
using JomarHealthCare.Application.DataModels.client.HospitalEntry;

namespace JomarHealthCare.Application.CQRS.Client.Commands.HospitalEntry;

public record CreateHospitalEnteryCommand(HospitalEntryDataModel DataModel) : IRequest<HospitalEntryDataModel>;
public record UpdateHospitalEnteryCommand(HospitalEntryDataModel DataModel) : IRequest<bool>;

public class DeleteHospitalEnteryCommand : IRequest<bool>
{
    public int Id { get; set; }
}
