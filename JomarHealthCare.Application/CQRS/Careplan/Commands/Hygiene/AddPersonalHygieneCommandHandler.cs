using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Hygiene;

public class AddPersonalHygieneCommandHandler : IRequestHandler<CreatePersonalHygieneCommand, PersonalHygieneDataModel>
{
    private readonly IPersonalHygieneRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddPersonalHygieneCommandHandler(IPersonalHygieneRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<PersonalHygieneDataModel> Handle(CreatePersonalHygieneCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<PersonalHygiene>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<PersonalHygieneDataModel>(created);
    }
}
