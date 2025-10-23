using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.MentalHealth;


internal class GetByClientMentalHeathQueryHandler : IRequestHandler<GetByClientMentalHealthQuery, MentalHealthSupportDataModel>
{
    private readonly IMentalHealthSupportRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientMentalHeathQueryHandler(IMentalHealthSupportRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<MentalHealthSupportDataModel> Handle(GetByClientMentalHealthQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new MentalHealthSupportDataModel();
        }

        return _mapper.Map<MentalHealthSupportDataModel>(entity);
    }
}

