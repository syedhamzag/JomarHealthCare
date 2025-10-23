using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.EquipmentDevices;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.EquipmentDevice;

internal class GetAllClientEquipmentDeviceByClientQueryHander : IRequestHandler<GetAllClientEquipmentDeviceByClientQuery, List<ClientEquipmentDeviceDataModel>>
{
    private readonly IClientEquipmentAssessmentRepository _repository;

    public GetAllClientEquipmentDeviceByClientQueryHander(IClientEquipmentAssessmentRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ClientEquipmentDeviceDataModel>> Handle(GetAllClientEquipmentDeviceByClientQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new ClientEquipmentDeviceDataModel
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
        }).ToList();
    }
}