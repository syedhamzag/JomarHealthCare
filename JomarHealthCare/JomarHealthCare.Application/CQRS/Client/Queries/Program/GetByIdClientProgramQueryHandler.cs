using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.Program;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Program;


internal class GetByIdClientProgramQueryHandler : IRequestHandler<GetByIdClientProgramQuery, ClientProgramDataModel>
{
    private readonly IClientProgramRepository _repository;
    private readonly IMapper _mapper;

    public GetByIdClientProgramQueryHandler(IClientProgramRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }


    public async Task<ClientProgramDataModel> Handle(GetByIdClientProgramQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);

        if (entity == null)
            return new ClientProgramDataModel();

        return _mapper.Map<ClientProgramDataModel>(entity);
    }
}
