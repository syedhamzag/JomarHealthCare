using MediatR;
using JomarHealthCare.Application.DataModels.Company;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Company.Commands
{
    public record UpdateCompanyProfileCommand(CompanyPorfileSettingDataModel DataModel) : IRequest;
    internal class ProfileUpdateCommandHandler : IRequestHandler<UpdateCompanyProfileCommand>
    {
        private readonly ICompanyRepository _repository;
        private readonly IUnitOfWork _uow;

        public ProfileUpdateCommandHandler(ICompanyRepository repository, IUnitOfWork uow)
        {
            _repository = repository;
            _uow = uow;
        }

        public async Task Handle(UpdateCompanyProfileCommand request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByKeyAsync(request.DataModel.CompanyId, cancellationToken);
            data.CompanyName = request.DataModel.CompanyName;
            data.Address = request.DataModel.Address;
            data.Website = request.DataModel.Website;
            data.LogoUrl = request.DataModel.LogoUrl;
            data.Language = request.DataModel.Language;
            data.PostCode = request.DataModel.PostCode;
            data.Telephone = request.DataModel.Telephone;
            data.Country = request.DataModel.Country;
            data.Currency = request.DataModel.Currency;
            data.CurrentCqcRating = request.DataModel.CurrentCqcRating;
            data.CityOfOperation = request.DataModel.CityOfOperation;
            data.OurPhilosophy = request.DataModel.OurPhilosophy;
            data.Purpose = request.DataModel.Purpose;
            data.Complaint = request.DataModel.Complaint;
            data.ContactUs = request.DataModel.ContactUs;
            data.PPE = request.DataModel.PPE;
            _repository.Update(data);
            await _uow.SaveChangesAsync(cancellationToken);
        }
    }
}
