using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Watch;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.ServiceWatch;

public class AddServiceWatchCommandHandler : IRequestHandler<CreateServiceWatchCommand, ClientServiceWatchDataModel>
{
    private readonly IClientServiceWatchRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddServiceWatchCommandHandler(IClientServiceWatchRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<ClientServiceWatchDataModel> Handle(CreateServiceWatchCommand request, CancellationToken cancellationToken)
    {
        DateTime now = DateTime.UtcNow;
        long unixTimeSeconds = new DateTimeOffset(now).ToUnixTimeSeconds();
        request.DataModel.Reference = Convert.ToString(unixTimeSeconds);
        var entity = _mapper.Map<ClientServiceWatch>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<ClientServiceWatchDataModel>(created);
    }
}