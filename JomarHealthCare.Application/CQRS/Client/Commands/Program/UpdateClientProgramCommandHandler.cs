using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Program;

public class UpdateClientProgramCommandHandler : IRequestHandler<UpdateClientProgramCommand, bool>
{
    private readonly IClientProgramRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public UpdateClientProgramCommandHandler(IClientProgramRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<bool> Handle(UpdateClientProgramCommand request, CancellationToken cancellationToken)
    {
        var existing = await _repo.GetByKeyAsync(request.DataModel.ProgramId, new CancellationToken());
        _mapper.Map(request.DataModel, existing); // This will update the scalar fields
        _repo.Update(existing);
        await _uow.SaveChangesAsync(cancellationToken);
        return true;
    }
}
