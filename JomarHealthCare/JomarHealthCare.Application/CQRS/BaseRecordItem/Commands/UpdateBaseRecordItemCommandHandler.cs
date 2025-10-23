using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.BaseRecordItem.Commands;


public class UpdateBaseRecordItemCommandHandler : IRequestHandler<UpdateBaseRecordItemCommand, bool>
{
    private readonly IBaseRecordItemRepository _baseRepository;
    private readonly IUnitOfWork _unitOfWork;
    public UpdateBaseRecordItemCommandHandler(IBaseRecordItemRepository baseRepository, IUnitOfWork unitOfWork)
    {
        _baseRepository = baseRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(UpdateBaseRecordItemCommand request, CancellationToken cancellationToken)
    {
        var data = await _baseRepository.GetByKeyAsync(request.BaseRecordItemId, cancellationToken);
        if (data == null) return false;

        data.ValueName = request.ValueName;

        _baseRepository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}