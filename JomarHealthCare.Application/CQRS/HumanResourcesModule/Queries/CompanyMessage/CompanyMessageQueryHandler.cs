using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.HumanResourcesModule.Queries
{
    public class CompanyMessageQueryHandler : IRequestHandler<CompanyMessageQuery, IQueryable<CompanyMessage>>
{
    private readonly ICompanyMessageRepository _repository;

    public CompanyMessageQueryHandler(ICompanyMessageRepository repository)
    {
        _repository = repository;
    }

    public async Task<IQueryable<CompanyMessage>> Handle(CompanyMessageQuery request, CancellationToken cancellationToken)
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