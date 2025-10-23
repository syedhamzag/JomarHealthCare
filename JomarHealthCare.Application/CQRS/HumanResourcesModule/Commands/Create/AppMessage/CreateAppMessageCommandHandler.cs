using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.HumanResourcesModule.AppMessage;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public class CreateAppMessageCommandHandler : IRequestHandler<CreateAppMessageCommand, AppMessageDataModel>
{
    private readonly IAppMessageRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public CreateAppMessageCommandHandler(IAppMessageRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<AppMessageDataModel> Handle(CreateAppMessageCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<AppMessage>(request.DataModel);
        var result = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<AppMessageDataModel>(result);
    }
}
}
