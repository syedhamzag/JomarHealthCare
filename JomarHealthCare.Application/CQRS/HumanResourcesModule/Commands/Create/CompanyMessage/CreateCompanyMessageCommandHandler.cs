using AutoMapper;
using FluentValidation;
using MediatR;
using JomarHealthCare.Application.DataModels.HumanResourcesModule.CompanyMessage;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public class CreateCompanyMessageCommandHandler : IRequestHandler<CreateCompanyMessageCommand, CompanyMessageDataModel>
{
    private readonly ICompanyMessageRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public CreateCompanyMessageCommandHandler(ICompanyMessageRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }
    

      public class CreateCompanyMessageDataModelValidator : AbstractValidator<CreateCompanyMessageCommand>
    {
        public CreateCompanyMessageDataModelValidator()
        {
            RuleFor(x => x.DataModel.CompanysMessage)
                .NotEmpty().WithMessage("Company's message is required.");

            RuleFor(x => x.DataModel.CreatedBy)
                .NotEmpty().WithMessage("CreatedBy is required.");
        }
    }

    public async Task<CompanyMessageDataModel> Handle(CreateCompanyMessageCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<CompanyMessage>(request.DataModel);
            var result = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<CompanyMessageDataModel>(result);
        }
}
}
