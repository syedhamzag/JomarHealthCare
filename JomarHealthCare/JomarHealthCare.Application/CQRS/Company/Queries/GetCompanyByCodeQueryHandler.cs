using MediatR;
using JomarHealthCare.Application.DataModels.Company;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Company.Queries;


internal class GetCompanyByCodeQueryHandler : IRequestHandler<GetCompanyByCode, CompanyDataModel>
{
    private readonly ICompanyRepository _repository;

    public GetCompanyByCodeQueryHandler(ICompanyRepository repository)
    {
        _repository = repository;
    }

    public async Task<CompanyDataModel> Handle(GetCompanyByCode request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetCompanyByCode(request.code);

        return new CompanyDataModel
        {
            CompanyId = entity.CompanyId
        };
    }
}