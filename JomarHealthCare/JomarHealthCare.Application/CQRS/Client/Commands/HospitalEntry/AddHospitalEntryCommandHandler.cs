using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.client.HospitalEntry;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.HospitalEntry;

public class AddHospitalEntryCommandHandler : IRequestHandler<CreateHospitalEnteryCommand, HospitalEntryDataModel>
{
    private readonly IClientHospitalEnteryRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddHospitalEntryCommandHandler(IClientHospitalEnteryRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<HospitalEntryDataModel> Handle(CreateHospitalEnteryCommand request, CancellationToken cancellationToken)
    {
        DateTime now = DateTime.UtcNow;
        long unixTimeSeconds = new DateTimeOffset(now).ToUnixTimeSeconds();
        request.DataModel.Reference = Convert.ToString(unixTimeSeconds);
        var entity = _mapper.Map<JomarHealthCare.Domain.Entities.HospitalEntry>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<HospitalEntryDataModel>(created);
    }
}