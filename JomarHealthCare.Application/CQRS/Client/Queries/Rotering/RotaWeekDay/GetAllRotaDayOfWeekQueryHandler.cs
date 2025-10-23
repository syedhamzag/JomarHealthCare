using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.Rotering;
using JomarHealthCare.Application.Repositories.Clients.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Rotering.RotaWeekDay;

internal class GetAllRotaDayOfWeekQueryHandler : IRequestHandler<GetAllRotaDayOfWeeKQuery, List<RotaDayofWeekDataModel>>
{

    private readonly IRotaDayOfWeekRepository _repository;
    private readonly IMapper _mapper;

    public GetAllRotaDayOfWeekQueryHandler(IRotaDayOfWeekRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<RotaDayofWeekDataModel>> Handle(GetAllRotaDayOfWeeKQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().ToListAsync(); // This method should return all records.

        return entities.Select(entity => new RotaDayofWeekDataModel
        {
            RotaDayofWeekId = entity.RotaDayofWeekId,
            DayofWeek = entity.DayofWeek
        }).ToList();
    }
}

