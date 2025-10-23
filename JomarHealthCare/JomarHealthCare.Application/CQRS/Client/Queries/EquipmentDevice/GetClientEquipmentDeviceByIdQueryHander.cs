using MediatR;
using JomarHealthCare.Application.DataModels.Client.EquipmentDevices;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.EquipmentDevice;


internal class GetClientEquipmentDeviceByIdQueryHander : IRequestHandler<GetClientEquipmentDeviceByIdQuery, ClientEquipmentDeviceDataModel>
{
    private readonly IClientEquipmentAssessmentRepository _repository;

    public GetClientEquipmentDeviceByIdQueryHander(IClientEquipmentAssessmentRepository repository)
    {
        _repository = repository;
    }

    public async Task<ClientEquipmentDeviceDataModel> Handle(GetClientEquipmentDeviceByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new ClientEquipmentDeviceDataModel
        {
            Id = entity.Id,
            EquipmentName = entity.EquipmentName,
            EquipmentLocation = entity.EquipmentLocation,
            EquipmentStatus = entity.EquipmentStatus,
            Url = entity.Url,
            ExpiryDate = entity.ExpiryDate,
            Training = entity.Training,
            ClientId = entity.ClientId,
            HowToUse = entity.HowToUse,
            RiskOfClient = entity.RiskOfClient,
            RiskOfStaff = entity.RiskOfStaff,
            Environment = entity.Environment,
            RiskControl = entity.RiskControl,
            Escalation = entity.Escalation,
            Attachment = entity.Attachment
        };
    }
}