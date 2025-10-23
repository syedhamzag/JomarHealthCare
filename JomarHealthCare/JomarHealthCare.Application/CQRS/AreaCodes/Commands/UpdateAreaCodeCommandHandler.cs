using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.AreaCodes.Commands;

public class UpdateAreaCodeCommandHandler : IRequestHandler<UpdateAreaCodeCommand, bool>
{
    private readonly IAreaCodeRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public UpdateAreaCodeCommandHandler(IAreaCodeRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(UpdateAreaCodeCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;

        data.Name = request.Name;
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}