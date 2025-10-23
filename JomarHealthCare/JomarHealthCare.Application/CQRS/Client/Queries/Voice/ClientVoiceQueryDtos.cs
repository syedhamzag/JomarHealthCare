using MediatR;
using JomarHealthCare.Application.DataModels.Voice;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Voice;

public record GetByClientVoiceQuery(Guid clientId) : IRequest<List<ClientVoiceDataModel>>;
public record GetByIdClientVoiceQuery(int id) : IRequest<ClientVoiceDataModel>;