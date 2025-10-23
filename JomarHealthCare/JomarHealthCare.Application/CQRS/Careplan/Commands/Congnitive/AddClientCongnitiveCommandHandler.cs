using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Congnitive;

public class AddClientCongnitiveCommandHandler : IRequestHandler<CreateCongnitiveCommand, CongnitiveDataModel>
{
    private readonly IClientCongnitiveRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddClientCongnitiveCommandHandler(IClientCongnitiveRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<CongnitiveDataModel> Handle(CreateCongnitiveCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<ClientCongnitive>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<CongnitiveDataModel>(created);
    }
}