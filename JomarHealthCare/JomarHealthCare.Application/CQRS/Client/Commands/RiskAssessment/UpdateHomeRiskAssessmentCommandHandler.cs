using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.RiskAssessment;

public class UpdateHomeRiskAssessmentCommandHandler : IRequestHandler<UpdateRiskAssessmentCommand, bool>
{
    private readonly IHomeRiskAssessmentRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public UpdateHomeRiskAssessmentCommandHandler(IHomeRiskAssessmentRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<bool> Handle(UpdateRiskAssessmentCommand request, CancellationToken cancellationToken)
    {
        var existing = await _repo.GetByKeyAsync(request.DataModel.HomeRiskAssessmentId, new CancellationToken());

       
        // Update main fields
        _mapper.Map(request.DataModel, existing); // This will update the scalar fields

        // Handle child tasks manually
        var incomingTasks = request.DataModel.HomeRiskAssessmentTask;

        foreach (var incoming in incomingTasks)
        {
            var existingTask = existing.HomeRiskAssessmentTask
                .FirstOrDefault(x => x.HomeRiskAssessmentTaskId == incoming.HomeRiskAssessmentTaskId);

            if (existingTask != null)
            {
                // Update existing task
                _mapper.Map(incoming, existingTask);
            }
            else
            {
                // Add new task
                var newTask = _mapper.Map<HomeRiskAssessmentTask>(incoming);
                existing.HomeRiskAssessmentTask.Add(newTask);
            }
        }
       
        _repo.Update(existing);
        await _uow.SaveChangesAsync(cancellationToken);
        return true;
    }
}