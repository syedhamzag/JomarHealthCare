using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.keyworker;


internal class GetByClientKeyworkerQueryHandler : IRequestHandler<GetByClientKeyworkerQuery, KeyworkerDataModel>
{
    private readonly IKeyworkerRepository _repository;

    public GetByClientKeyworkerQueryHandler(IKeyworkerRepository repository)
    {
        _repository = repository;
    }

    public async Task<KeyworkerDataModel> Handle(GetByClientKeyworkerQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new KeyworkerDataModel();
        }
        return new KeyworkerDataModel
        {
            Id = entity.Id,
            KeyworkerId = entity.KeyworkerId,
            OtherStaffId = entity.OtherStaffId,
            Notes = entity.Notes,
            AccessInfo = entity.AccessInfo,
            ClientId = entity.ClientId,
        };
    }
}