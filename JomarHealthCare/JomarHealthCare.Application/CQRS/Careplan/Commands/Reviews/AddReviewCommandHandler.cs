using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Reviews;
public class AddReviewCommandHandler : IRequestHandler<CreateReviewCommand, ReviewDataModel>
{
    private readonly IReviewRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddReviewCommandHandler(IReviewRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<ReviewDataModel> Handle(CreateReviewCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Review>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<ReviewDataModel>(created);
    }
}