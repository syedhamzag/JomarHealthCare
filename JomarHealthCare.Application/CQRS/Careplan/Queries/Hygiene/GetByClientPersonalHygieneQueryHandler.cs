using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Hygiene;

internal class GetByClientPersonalHygieneQueryHandler : IRequestHandler<GetByClientPersonalHygieneQuery, PersonalHygieneDataModel>
{
    private readonly IPersonalHygieneRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientPersonalHygieneQueryHandler(IPersonalHygieneRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<PersonalHygieneDataModel> Handle(GetByClientPersonalHygieneQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new PersonalHygieneDataModel();
        }

        return _mapper.Map<PersonalHygieneDataModel>(entity);
    }
}

