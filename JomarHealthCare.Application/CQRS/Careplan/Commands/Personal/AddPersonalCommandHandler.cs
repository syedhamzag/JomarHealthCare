using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Personal;

public class AddPersonalCommandHandler : IRequestHandler<CreatePersonalCommand, PersonalDataModel>
{
    private readonly IPersonalRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddPersonalCommandHandler(IPersonalRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<PersonalDataModel> Handle(CreatePersonalCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<JomarHealthCare.Domain.Entities.Personal>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<PersonalDataModel>(created);
    }
}