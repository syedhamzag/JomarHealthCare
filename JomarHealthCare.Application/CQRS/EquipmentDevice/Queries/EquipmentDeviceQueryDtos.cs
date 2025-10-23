using MediatR;
using JomarHealthCare.Application.DataModels.EquipmentAssess;
using JomarHealthCare.Application.ResponseModels;

namespace JomarHealthCare.Application.CQRS.EquipmentDevice.Queries;

public record GetEquipmentDeviceByIdQuery(int Id) : IRequest<DefaultResponse<EquipmentDeviceDataViewModel>>;
