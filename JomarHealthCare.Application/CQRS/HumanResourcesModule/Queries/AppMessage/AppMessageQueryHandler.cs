using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.HumanResourcesModule.Queries
{
    public class AppMessageQueryHandler : IRequestHandler<AppMessageQuery, IQueryable<AppMessage>>
{
    private readonly IAppMessageRepository _repository;

    public AppMessageQueryHandler(IAppMessageRepository repository)
    {
        _repository = repository;
    }

    public async Task<IQueryable<AppMessage>> Handle(AppMessageQuery request, CancellationToken cancellationToken)
    {
        var key = request.Id.ToString().Trim();
        if (!string.IsNullOrEmpty(request.Id))
        {
            return _repository.Get(x => x.Id.ToString().Trim() == key);
        }
        return _repository.Get();
    }
}
}