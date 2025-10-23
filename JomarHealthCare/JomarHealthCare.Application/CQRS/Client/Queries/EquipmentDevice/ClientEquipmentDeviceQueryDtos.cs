using MediatR;
using JomarHealthCare.Application.DataModels.Client.EquipmentDevices;

namespace JomarHealthCare.Application.CQRS.Client.Queries.EquipmentDevice;

public record GetClientEquipmentDeviceByIdQuery(int id) : IRequest<ClientEquipmentDeviceDataModel>;

public record GetAllClientEquipmentDeviceByClientQuery(Guid clientId) : IRequest<List<ClientEquipmentDeviceDataModel>>;