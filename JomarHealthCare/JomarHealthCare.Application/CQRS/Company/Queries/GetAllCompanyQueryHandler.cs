using MediatR;
using JomarHealthCare.Application.DataModels.Company;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Company.Queries;
internal class GetAllCompanyQueryHandler : IRequestHandler<GetAllCompanyQuery, List<CompanyDataModel>>
{
    private readonly ICompanyRepository _repository;

    public GetAllCompanyQueryHandler(ICompanyRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<CompanyDataModel>> Handle(GetAllCompanyQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAll(); // This method should return all records.
    }
}
