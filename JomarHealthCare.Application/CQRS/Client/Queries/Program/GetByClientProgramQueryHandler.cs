using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.Program;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Program;


internal class GetByClientProgramQueryHandler : IRequestHandler<GetByClientProgramQuery, List<ClientProgramDataModel>>
{
    private readonly IClientProgramRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientProgramQueryHandler(IClientProgramRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ClientProgramDataModel>> Handle(GetByClientProgramQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).ToListAsync();

        if (entities == null || entities.Count == 0)
            return new List<ClientProgramDataModel>();

        return _mapper.Map<List<ClientProgramDataModel>>(entities);
    }
}