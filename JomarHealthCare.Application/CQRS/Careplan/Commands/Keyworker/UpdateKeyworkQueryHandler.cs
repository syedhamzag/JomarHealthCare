using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Keyworker;


public class UpdateKeyworkQueryHandler : IRequestHandler<UpdateKeyworkerCommand, bool>
{
    private readonly IKeyworkerRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public UpdateKeyworkQueryHandler(IKeyworkerRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<bool> Handle(UpdateKeyworkerCommand request, CancellationToken cancellationToken)
    {
        var existing = await _repo.GetByKeyAsync(request.DataModel.Id, new CancellationToken());
        _mapper.Map(request.DataModel, existing); // This will update the scalar fields
        _repo.Update(existing);
        await _uow.SaveChangesAsync(cancellationToken);
        return true;
    }
}