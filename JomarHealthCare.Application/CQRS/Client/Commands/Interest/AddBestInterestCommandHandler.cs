using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.BestInterest;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Interest;

public class AddBestInterestCommandHandler : IRequestHandler<CreateClientBestInterestCommand, BestInterestDataModel>
{
    private readonly IClientBestInterestRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddBestInterestCommandHandler(IClientBestInterestRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<BestInterestDataModel> Handle(CreateClientBestInterestCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<BestInterestAssessment>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<BestInterestDataModel>(created);
    }
}