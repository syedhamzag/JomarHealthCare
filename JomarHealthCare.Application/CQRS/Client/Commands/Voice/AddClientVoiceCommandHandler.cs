using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Voice;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Voice;

public class AddClientVoiceCommandHandler : IRequestHandler<CreateClientVoiceCommand, ClientVoiceDataModel>
{
    private readonly IClientVoiceRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddClientVoiceCommandHandler(IClientVoiceRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<ClientVoiceDataModel> Handle(CreateClientVoiceCommand request, CancellationToken cancellationToken)
    {
        DateTime now = DateTime.UtcNow;
        long unixTimeSeconds = new DateTimeOffset(now).ToUnixTimeSeconds();
        request.DataModel.Reference = Convert.ToString(unixTimeSeconds);
        var entity = _mapper.Map<ClientVoice>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<ClientVoiceDataModel>(created);
    }
}