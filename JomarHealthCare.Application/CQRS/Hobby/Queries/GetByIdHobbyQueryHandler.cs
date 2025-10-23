using MediatR;
using JomarHealthCare.Application.DataModels.Hobby;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Hobby.Queries;

internal class GetByIdHobbyQueryHandler : IRequestHandler<GetHobbyByIdQuery, HobbyDataModel>
{
    private readonly IHobbyRepository _repository;

    public GetByIdHobbyQueryHandler(IHobbyRepository repository)
    {
        _repository = repository;
    }

    public async Task<HobbyDataModel> Handle(GetHobbyByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.HId, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new HobbyDataModel
        {
            HId = entity.HId,
            Name = entity.Name,
            Description = entity.Description,
            CompanyId = entity.CompanyId
        };
    }
}