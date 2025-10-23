using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Consent;


public class AddConsentCommandHandler : IRequestHandler<CreateConsentDataCommand, ConsentDataModel>
{
    private readonly IConsentDataRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddConsentCommandHandler(IConsentDataRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<ConsentDataModel> Handle(CreateConsentDataCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<ConsentData>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<ConsentDataModel>(created);
    }
}
