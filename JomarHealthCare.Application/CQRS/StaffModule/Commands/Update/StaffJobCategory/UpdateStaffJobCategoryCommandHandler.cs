using MediatR;
using JomarHealthCare.Application.CQRS.StaffModule.Commands.CommandDtos;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.StaffModule.Commands.Update.StaffJobCategory;

public class UpdateStaffJobCategoryCommandHandler : IRequestHandler<UpdateJobCategoryCommand, bool>
{
    private readonly IJobCategoryRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public UpdateStaffJobCategoryCommandHandler(IJobCategoryRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(UpdateJobCategoryCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;

        data.CategoryName = request.Name;
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}