using MediatR;
using JomarHealthCare.Application.DataModels.Client.HospitalExit;

namespace JomarHealthCare.Application.CQRS.Client.Commands.HospitalExit;


public record CreateHospitalExitCommand(HospitalExitDataModel DataModel) : IRequest<HospitalExitDataModel>;
public record UpdateHospitalExitCommand(HospitalExitDataModel DataModel) : IRequest<bool>;

public class DeleteHospitalExitCommand : IRequest<bool>
{
    public int Id { get; set; }
}
