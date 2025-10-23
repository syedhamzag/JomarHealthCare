using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.HumanResourcesModule.Complaints;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.HumanResourcesModule.Commands.ComplainRegister;


public class AddComplainRegisterCommandHandler : IRequestHandler<CreateComplainRegisterCommand, ComplainRegistorDataModel>
{
    private readonly IComplainRegistorRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddComplainRegisterCommandHandler(IComplainRegistorRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<ComplainRegistorDataModel> Handle(CreateComplainRegisterCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<ComplainRegistor>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<ComplainRegistorDataModel>(created);
    }
}
