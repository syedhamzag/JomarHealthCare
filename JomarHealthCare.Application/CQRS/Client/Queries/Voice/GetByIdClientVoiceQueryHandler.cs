using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Voice;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Voice;

internal class GetByIdClientVoiceQueryHandler : IRequestHandler<GetByIdClientVoiceQuery, ClientVoiceDataModel>
{
    private readonly IClientVoiceRepository _repository;
    private readonly IMapper _mapper;

    public GetByIdClientVoiceQueryHandler(IClientVoiceRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ClientVoiceDataModel> Handle(GetByIdClientVoiceQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);
        if (entity == null)
            return new ClientVoiceDataModel();

        return _mapper.Map<ClientVoiceDataModel>(entity);
    }
}