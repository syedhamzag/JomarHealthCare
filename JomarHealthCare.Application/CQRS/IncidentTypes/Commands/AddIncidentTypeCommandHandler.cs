using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.Rotering;
using JomarHealthCare.Application.DataModels.IncidentType;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.IncidentTypes.Commands;

public class AddIncidentTypeCommandHandler : IRequestHandler<CreateIncidentTypeCommand, IncidentTypeDataModel>
{
    private readonly IIncidentTypeRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddIncidentTypeCommandHandler(IIncidentTypeRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<IncidentTypeDataModel> Handle(CreateIncidentTypeCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<IncidentType>(request.DataModel); // DutyOnCall type now correctly resolved
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<IncidentTypeDataModel>(created);
    }
}