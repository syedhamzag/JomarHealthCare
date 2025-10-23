using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.DutyOnCall;

public class UpdateDutyOnCallCommandHandler : IRequestHandler<UpdateDutyOnCallCommand, bool>
{
    private readonly IClientDutyOnCallRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public UpdateDutyOnCallCommandHandler(IClientDutyOnCallRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<bool> Handle(UpdateDutyOnCallCommand request, CancellationToken cancellationToken)
    {
        var existing = await _repo.GetByKeyAsync(request.DataModel.DutyOnCallId, new CancellationToken());


        // Update main fields
        _mapper.Map(request.DataModel, existing); // This will update the scalar fields

        // Handle child tasks manually
        var incomingTasks = request.DataModel.PersonResponsible;

        foreach (var incoming in incomingTasks)
        {
            var existingTask = existing.PersonResponsible
                .FirstOrDefault(x => x.PersonResponsibleId == incoming.PersonResponsibleId);

            if (existingTask != null)
            {
                // Update existing task
                _mapper.Map(incoming, existingTask);
            }
            else
            {
                // Add new task
                var newTask = _mapper.Map<DutyOnCallPersonResponsible>(incoming);
                existing.PersonResponsible.Add(newTask);
            }
        }

        var incomingActs = request.DataModel.PersonToAct;

        foreach (var incoming in incomingActs)
        {
            var existingActTask = existing.PersonToAct
                .FirstOrDefault(x => x.PersonToActId == incoming.PersonToActId);

            if (existingActTask != null)
            {
                // Update existing task
                _mapper.Map(incoming, existingActTask);
            }
            else
            {
                // Add new task
                var newTask = _mapper.Map<DutyOnCallPersonToAct>(incoming);
                existing.PersonToAct.Add(newTask);
            }
        }

        _repo.Update(existing);
        await _uow.SaveChangesAsync(cancellationToken);
        return true;
    }
}