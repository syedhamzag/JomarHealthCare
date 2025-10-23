using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.InterestObjective;

public class UpdateInterestAndObjectiveCommandHandler : IRequestHandler<UpdateInterestAndObjectiveCommand, bool>
{
    private readonly IClientInterestAndObjectiveRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public UpdateInterestAndObjectiveCommandHandler(IClientInterestAndObjectiveRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<bool> Handle(UpdateInterestAndObjectiveCommand request, CancellationToken cancellationToken)
    {
        var existing = await _repo.GetByKeyAsync(request.DataModel.GoalId, new CancellationToken());


        // Update main fields
        _mapper.Map(request.DataModel, existing); // This will update the scalar fields

        // Handle child tasks manually
        var incomingTasks = request.DataModel.PersonalityTest;

        foreach (var incoming in incomingTasks)
        {
            var existingTask = existing.PersonalityTest
                .FirstOrDefault(x => x.TestId == incoming.TestId);

            if (existingTask != null)
            {
                // Update existing task
                _mapper.Map(incoming, existingTask);
            }
            else
            {
                // Add new task
                var newTask = _mapper.Map<PersonalityTest>(incoming);
                existing.PersonalityTest.Add(newTask);
            }
        }

        _repo.Update(existing);
        await _uow.SaveChangesAsync(cancellationToken);
        return true;
    }
}