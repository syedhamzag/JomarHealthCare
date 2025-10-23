using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Identity;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.DataModels.IncidentDetails;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.IncidentDetails.Commands;


internal class AddIncidentDetailCommandHandler : IRequestHandler<AddIncidentDetailCommand, IncidentDetailDataModel>
{
    private readonly IEmailService _emailService;
    private readonly IIncidentDetailRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddIncidentDetailCommandHandler(IEmailService emailService,
        IIncidentDetailRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _mapper = mapper;
        _uow = uow;
        _emailService = emailService;
        _repo = repo;
    }

    public async Task<IncidentDetailDataModel> Handle(AddIncidentDetailCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<IncidentDetail>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<IncidentDetailDataModel>(created);
    }
}
