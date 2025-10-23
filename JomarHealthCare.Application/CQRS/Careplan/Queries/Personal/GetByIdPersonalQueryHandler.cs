using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Personal;

internal class GetByIdPersonalQueryHandler : IRequestHandler<GetByClientPersonalQuery, PersonalDataModel>
{
    private readonly IPersonalRepository _repository;

    public GetByIdPersonalQueryHandler(IPersonalRepository repository)
    {
        _repository = repository;
    }

    public async Task<PersonalDataModel> Handle(GetByClientPersonalQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new PersonalDataModel();
        }

        return new PersonalDataModel
        {
            PersonalId = entity.PersonalId,
            ClientId = entity.ClientId,
            Religion = entity.Religion,
            Nationality = entity.Nationality,
            Smoking = entity.Smoking,
            DNR = entity.DNR
        };
    }
}