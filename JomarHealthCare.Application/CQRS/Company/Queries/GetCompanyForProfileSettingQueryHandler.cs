using MediatR;
using JomarHealthCare.Application.DataModels.Company;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Company.Queries;

internal class GetCompanyForProfileSettingQueryHandler : IRequestHandler<GetCompanyForProfileSettingQuery, CompanyPorfileSettingDataModel>
{
    private readonly ICompanyRepository _repository;

    public GetCompanyForProfileSettingQueryHandler(ICompanyRepository repository)
    {
        _repository = repository;
    }

    public async Task<CompanyPorfileSettingDataModel> Handle(GetCompanyForProfileSettingQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.CompanyId, cancellationToken);

        return new CompanyPorfileSettingDataModel
        {
            CompanyId = entity.CompanyId,
            CompanyName = entity.CompanyName,
            Address = entity.Address,
            Website = entity.Website,
            LogoUrl = entity.LogoUrl,
            Language = entity.Language,
            PostCode = entity.PostCode,
            Telephone = entity.Telephone,
            Country = entity.Country,
            Currency = entity.Currency,
            CurrentCqcRating = entity.CurrentCqcRating,
            CityOfOperation = entity.CityOfOperation,
            OurPhilosophy = entity.OurPhilosophy,
            Purpose = entity.Purpose,
            Complaint = entity.Complaint,
            ContactUs = entity.ContactUs,
            PPE = entity.PPE
        };
    }
}