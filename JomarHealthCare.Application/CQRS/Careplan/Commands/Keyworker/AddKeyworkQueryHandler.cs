using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Keyworker;

public class AddKeyworkQueryHandler : IRequestHandler<CreateKeyworkerCommand, KeyworkerDataModel>
{
    private readonly IKeyworkerRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddKeyworkQueryHandler(IKeyworkerRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<KeyworkerDataModel> Handle(CreateKeyworkerCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<ClientKeyworkerNotes>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<KeyworkerDataModel>(created);
    }
}