using MediatR;
using JomarHealthCare.Application.CQRS.StaffModule.Commands.CommandDtos;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.StaffModule.Commands.Create.StaffJobCategory;


public class AddStaffJobCategoryCommandHandler : IRequestHandler<AddJobCategoryCommand, CategoryOfStaff>
{
    private readonly IJobCategoryRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public AddStaffJobCategoryCommandHandler(IJobCategoryRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<CategoryOfStaff> Handle(AddJobCategoryCommand request, CancellationToken cancellationToken)
    {
        var data = new CategoryOfStaff
        {
            CategoryName = request.Name,
            CompanyId = request.CompanyId
        };

        await _repository.AddAsync(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return data;
    }
}