using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.BaseRecordItem.Commands;

public class CreateBaseRecordItemCommandHandler : IRequestHandler<CreateBaseRecordItemCommand, BaseRecordItemModel>
{
    private readonly IBaseRecordItemRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public CreateBaseRecordItemCommandHandler(IBaseRecordItemRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<BaseRecordItemModel> Handle(CreateBaseRecordItemCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var data = new BaseRecordItemModel
            {
                BaseRecordId = request.BaseRecordId,
                ValueName = request.ValueName,
                CreatedBy = request.CreatedBy,
            };

            await _repository.AddAsync(data);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return data;
        }
        catch (Exception ex)
        {

            throw;
        }

    }
}