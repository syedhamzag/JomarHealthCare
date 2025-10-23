using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.Rotering;
using JomarHealthCare.Application.Repositories.Clients.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Rotering.RotaTasks;

internal class GetByIdRotaTaskQueryHandler : IRequestHandler<GetByIdRotaTaskQuery, RotaTaskDataModel>
{
    private readonly IRotaTaskRepository _repository;
    private readonly IMapper _mapper;

    public GetByIdRotaTaskQueryHandler(IRotaTaskRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<RotaTaskDataModel> Handle(GetByIdRotaTaskQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().FirstOrDefaultAsync(x => x.RotaTaskId == request.id);
        if (entity == null)
        {
            return new RotaTaskDataModel();
        }
        return new RotaTaskDataModel
        {
            RotaTaskId = entity.RotaTaskId,
            TaskName = entity.TaskName,
            GivenAcronym = entity.GivenAcronym,
            NotGivenAcronym = entity.NotGivenAcronym,
            Remark = entity.Remark,
        };
    }
}