using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Centred;


internal class GetByClientPersonCentredQueryHandler : IRequestHandler<GetByClientPersonCentredQuery, List<GetPersonCentredModelData>>
{
    private readonly IPersonCentredRepository _repository;

    public GetByClientPersonCentredQueryHandler(IPersonCentredRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetPersonCentredModelData>> Handle(GetByClientPersonCentredQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId).ToListAsync();

        return entities.Select(entity => new GetPersonCentredModelData
        {
            PersonCentredId = entity.PersonCentredId,
            Class = entity.Class,
            ExpSupport = entity.ExpSupport,
            Focus = entity.Focus,
            ClientId = entity.ClientId,
        }).ToList();
    }
}