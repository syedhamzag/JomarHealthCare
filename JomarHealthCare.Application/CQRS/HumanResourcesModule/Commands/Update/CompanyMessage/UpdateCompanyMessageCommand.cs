using MediatR;
using JomarHealthCare.Application.DataModels.HumanResourcesModule.CompanyMessage;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public record UpdateCompanyMessageCommand(CompanyMessageDataModel DataModel) : IRequest<bool>;
}
