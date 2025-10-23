using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Identity;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.DataModels.ReportedConcerns;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.ReportedConcerns.Commands;


internal class AddReportedConcernCommandHandler : IRequestHandler<AddReportedConcernCommand, ReportedConcernDataModel>
{
    private readonly IEmailService _emailService;
    private readonly IReportedConcernRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddReportedConcernCommandHandler(IEmailService emailService,
        IReportedConcernRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _mapper = mapper;
        _uow = uow;
        _emailService = emailService;
        _repo = repo;
    }

    public async Task<ReportedConcernDataModel> Handle(AddReportedConcernCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<ReportedConcern>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<ReportedConcernDataModel>(created);
    }
}
