using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public class UpdateAppMessageCommandHandler : IRequestHandler<UpdateAppMessageCommand, bool>
{
    private readonly IAppMessageRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public UpdateAppMessageCommandHandler(IAppMessageRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<bool> Handle(UpdateAppMessageCommand request, CancellationToken cancellationToken)
    {
        var entity = await _repo.Get(x => x.Id == request.DataModel.Id).FirstOrDefaultAsync();
        if (entity == null) throw new KeyNotFoundException($"AppMessage with ID {request.DataModel.Id} not found.");

        _mapper.Map(request.DataModel, entity);
        _repo.Update(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return true;
    }
}
}
