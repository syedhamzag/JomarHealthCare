using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Voice;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Voice;


internal class GetByClientVoiceQueryHandler : IRequestHandler<GetByClientVoiceQuery, List<ClientVoiceDataModel>>
{
    private readonly IClientVoiceRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientVoiceQueryHandler(IClientVoiceRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ClientVoiceDataModel>> Handle(GetByClientVoiceQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).ToListAsync();

        if (entities == null || entities.Count == 0)
            return new List<ClientVoiceDataModel>();

        return _mapper.Map<List<ClientVoiceDataModel>>(entities);
    }
}