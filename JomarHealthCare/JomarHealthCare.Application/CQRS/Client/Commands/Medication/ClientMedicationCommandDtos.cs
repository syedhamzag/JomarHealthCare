using MediatR;
using JomarHealthCare.Application.DataModels.Client.Medication;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Medication;

public record CreateClientMedicationCommand(ClientMedicationDataModel DataModel) : IRequest<ClientMedicationDataModel>;
public record UpdateClientMedicationCommand(ClientMedicationDataModel DataModel) : IRequest<bool>;


public class DeleteClientMedicationCommand : IRequest<bool>
{
    public int Id { get; set; }
}