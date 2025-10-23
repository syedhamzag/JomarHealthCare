using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.BodyMap;


internal class GetByIdBodyMapQueryHandler : IRequestHandler<GetByIdBodyMapQuery, BodyMapDataModel>
{
    private readonly IBodyMapRepository _repository;

    public GetByIdBodyMapQueryHandler(IBodyMapRepository repository)
    {
        _repository = repository;
    }

    public async Task<BodyMapDataModel> Handle(GetByIdBodyMapQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);

        return new BodyMapDataModel
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
        };
    }
}
