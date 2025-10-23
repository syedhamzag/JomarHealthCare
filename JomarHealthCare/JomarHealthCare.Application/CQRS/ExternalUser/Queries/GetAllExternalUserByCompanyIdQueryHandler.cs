using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.ExternalUser;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.ExternalUser.Queries;


internal class GetAllExternalUserByCompanyIdQueryHandler : IRequestHandler<GetAllExternalUserByIdQuery, List<ExternalUserDataModel>>
{
    private readonly IExternalRoleRepository _repository;

    public GetAllExternalUserByCompanyIdQueryHandler(IExternalRoleRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ExternalUserDataModel>> Handle(GetAllExternalUserByIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CreatedBy == request.id.ToString()).Include(s=>s.User).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new ExternalUserDataModel
        {
            CreatedBy = entity.CreatedBy,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            Telephone = entity.Telephone,
            ExternalId = entity.ExternalId,
            Password = entity.Password,
            UserId = entity.UserId,
            Email = entity.User.Email,
            Username = entity.User.UserName
        }).ToList();
    }
}