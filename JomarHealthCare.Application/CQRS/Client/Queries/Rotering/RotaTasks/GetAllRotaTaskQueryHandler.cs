using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.Rotering;
using JomarHealthCare.Application.Repositories.Clients.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Rotering.RotaTasks;
internal class GetAllRotaTaskQueryHandler : IRequestHandler<GetAllRotaTaskQuery, List<RotaTaskDataModel>>
{

    private readonly IRotaTaskRepository _repository;
    private readonly IMapper _mapper;

    public GetAllRotaTaskQueryHandler(IRotaTaskRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<RotaTaskDataModel>> Handle(GetAllRotaTaskQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CompanyId == null && !x.Deleted).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new RotaTaskDataModel
        {
            RotaTaskId = entity.RotaTaskId,
            TaskName = entity.TaskName,
            GivenAcronym = entity.GivenAcronym,
            NotGivenAcronym = entity.NotGivenAcronym,
            Remark = entity.Remark,
            CompanyId = entity.CompanyId,
        }).ToList();
    }
}
