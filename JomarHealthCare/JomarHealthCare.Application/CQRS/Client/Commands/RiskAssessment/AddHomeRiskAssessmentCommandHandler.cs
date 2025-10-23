using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.RiskAssessment;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.RiskAssessment;


public class AddHomeRiskAssessmentCommandHandler : IRequestHandler<CreateRiskAssessmentCommand, HomeRiskAssessmentDataModel>
{
    private readonly IHomeRiskAssessmentRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddHomeRiskAssessmentCommandHandler(IHomeRiskAssessmentRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<HomeRiskAssessmentDataModel> Handle(CreateRiskAssessmentCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<HomeRiskAssessment>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<HomeRiskAssessmentDataModel>(created);
    }
}
