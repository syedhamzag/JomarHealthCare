using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.ExternalUser;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.ExternalUser.Queries;

internal class GetExternalUserByIdQueryHandler : IRequestHandler<GetExternalUserByIdQuery, ExternalUserDataModel>
{
    private readonly IExternalRoleRepository _repository;

    public GetExternalUserByIdQueryHandler(IExternalRoleRepository repository)
    {
        _repository = repository;
    }

    public async Task<ExternalUserDataModel> Handle(GetExternalUserByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(s => s.ExternalId ==request.id).Include(s=>s.User).FirstOrDefaultAsync(cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new ExternalUserDataModel
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
        };
    }
}