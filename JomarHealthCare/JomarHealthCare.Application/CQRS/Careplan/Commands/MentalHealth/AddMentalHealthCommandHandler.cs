using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.MentalHealth;

public class AddMentalHealthCommandHandler : IRequestHandler<CreateMentalHealthCommand, MentalHealthSupportDataModel>
{
    private readonly IMentalHealthSupportRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddMentalHealthCommandHandler(IMentalHealthSupportRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<MentalHealthSupportDataModel> Handle(CreateMentalHealthCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<MentalHealthSupport>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<MentalHealthSupportDataModel>(created);
    }
}