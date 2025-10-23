using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.InterestObjective;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.InterestObjective;

internal class GetAllInterestAndObjectiveByClientQueryHandler : IRequestHandler<GetAllInterestAndObjectiveByClientQuery, ClientInterestAndObjectiveDataModel>
{
    private readonly IClientInterestAndObjectiveRepository _repository;

    public GetAllInterestAndObjectiveByClientQueryHandler(IClientInterestAndObjectiveRepository repository)
    {
        _repository = repository;
    }

    public async Task<ClientInterestAndObjectiveDataModel> Handle(GetAllInterestAndObjectiveByClientQuery request, CancellationToken cancellationToken)
    {
        return await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).Include(x => x.PersonalityTest)
            .Select(x => new ClientInterestAndObjectiveDataModel
            {
                GoalId = x.GoalId,
                CareGoal = x.CareGoal,
                Brief = x.Brief,
                InterestId = x.InterestId,
                LeisureActivity = x.LeisureActivity,
                InformalActivity = x.InformalActivity,
                MaintainContact = x.MaintainContact,
                CommunityActivity = x.CommunityActivity,
                EventAwarness = x.EventAwarness,
                GoalAndObjective = x.GoalAndObjective,
                PersonalityTest = x.PersonalityTest.Select(pt => new PersonalityTestDataModel
                {
                    TestId = pt.TestId,
                    GoalId = pt.GoalId,
                    Question = pt.Question,
                    Answer = pt.Answer
                }).ToList(),
            })
            .FirstOrDefaultAsync();
    }
}