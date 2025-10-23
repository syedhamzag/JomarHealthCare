using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.HospitalExit;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.HospitalExit;


public class AddHospitalExitCommandHandler : IRequestHandler<CreateHospitalExitCommand, HospitalExitDataModel>
{
    private readonly IHospitalExitRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddHospitalExitCommandHandler(IHospitalExitRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<HospitalExitDataModel> Handle(CreateHospitalExitCommand request, CancellationToken cancellationToken)
    {
        DateTime now = DateTime.UtcNow;
        long unixTimeSeconds = new DateTimeOffset(now).ToUnixTimeSeconds();
        request.DataModel.Reference = Convert.ToString(unixTimeSeconds);
        var entity = _mapper.Map<JomarHealthCare.Domain.Entities.HospitalExit>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<HospitalExitDataModel>(created);
    }
}