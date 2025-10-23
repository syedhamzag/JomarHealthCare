using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.BodyMap;

internal class GetByClientBodyMapQueryHandler : IRequestHandler<GetByClientBodyMapQuery, List<BodyMapDataModel>>
{
    private readonly IBodyMapRepository _repository;

    public GetByClientBodyMapQueryHandler(IBodyMapRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<BodyMapDataModel>> Handle(GetByClientBodyMapQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).ToListAsync();

        return entities.Select(entity => new BodyMapDataModel
        {
            BodyMapId = entity.BodyMapId,
            StaffRotaPeriodId = entity.StaffRotaPeriodId,
            CreamName = entity.CreamName,
            PurposeOfCream = entity.PurposeOfCream,
            HowToApply = entity.HowToApply,
            Instruction = entity.Instruction,
            AreaApplied = entity.AreaApplied,
            Escalation = entity.Escalation,
            Date = entity.Date,
            ClientId = entity.ClientId,
        }).ToList();
    }
}