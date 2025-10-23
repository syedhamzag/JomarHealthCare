using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.Rotering;
using JomarHealthCare.Application.Repositories.Clients.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Rotering.ClientRota;

public class AddClientRotaCommandHandler : IRequestHandler<CreateClientRotaCommand, List<ClientRotaDataModel>>
{
    private readonly IClientRotaRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddClientRotaCommandHandler(IClientRotaRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<List<ClientRotaDataModel>> Handle(CreateClientRotaCommand request, CancellationToken cancellationToken)
    {
        var result = new List<JomarHealthCare.Domain.Entities.ClientRota>();

        foreach (var model in request.DataModel)
        {
            // Check if it exists in DB
            var existing = await _repo.GetByKeyAsync(model.ClientRotaId, new CancellationToken());
            if (existing != null)
            {
                // Update existing entity
                _mapper.Map(model, existing); // Updates fields of the existing entity
                _repo.Update(existing);
                result.Add(existing);
            }
            else
            {
                // Create new entity
                var newEntity = _mapper.Map<JomarHealthCare.Domain.Entities.ClientRota>(model);
                await _repo.AddAsync(newEntity);
                result.Add(newEntity);
            }
        }

        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<List<ClientRotaDataModel>>(result);
    }
}