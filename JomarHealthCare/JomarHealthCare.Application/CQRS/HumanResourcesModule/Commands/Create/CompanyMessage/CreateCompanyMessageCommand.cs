using MediatR;
using JomarHealthCare.Application.DataModels.HumanResourcesModule.CompanyMessage;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public record CreateCompanyMessageCommand(CompanyMessageDataModel DataModel) : IRequest<CompanyMessageDataModel>;
}
