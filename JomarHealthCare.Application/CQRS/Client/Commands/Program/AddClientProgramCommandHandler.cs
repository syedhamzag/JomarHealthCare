using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.Program;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Program;

public class AddClientProgramCommandHandler : IRequestHandler<CreateClientProgramCommand, ClientProgramDataModel>
{
    private readonly IClientProgramRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddClientProgramCommandHandler(IClientProgramRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<ClientProgramDataModel> Handle(CreateClientProgramCommand request, CancellationToken cancellationToken)
    {
        DateTime now = DateTime.UtcNow;
        long unixTimeSeconds = new DateTimeOffset(now).ToUnixTimeSeconds();
        request.DataModel.Reference = Convert.ToString(unixTimeSeconds);
        var entity = _mapper.Map<ClientProgram>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<ClientProgramDataModel>(created);
    }
}