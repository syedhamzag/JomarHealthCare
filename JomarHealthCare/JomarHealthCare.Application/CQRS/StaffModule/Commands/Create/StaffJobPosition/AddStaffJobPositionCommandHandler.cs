using MediatR;
using JomarHealthCare.Application.CQRS.StaffModule.Commands.CommandDtos;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.StaffModule.Commands.Create.StaffJobPosition;

public class AddStaffJobPositionCommandHandler : IRequestHandler<AddJobPositionCommand, JobPosition>
{
    private readonly IJobPositionRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public AddStaffJobPositionCommandHandler(IJobPositionRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<JobPosition> Handle(AddJobPositionCommand request, CancellationToken cancellationToken)
    {
        var data = new JobPosition
        {
            Name = request.Name,
            CompanyId = request.CompanyId
        };

        await _repository.AddAsync(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return data;
    }
}