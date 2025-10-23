using MediatR;
using JomarHealthCare.Application.CQRS.StaffModule.Commands.CommandDtos;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.StaffModule.Commands.Update.StaffJobPosition;

public class UpdateStaffJobPositionCommandHandler : IRequestHandler<UpdateJobPositionCommand, bool>
{
    private readonly IJobPositionRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public UpdateStaffJobPositionCommandHandler(IJobPositionRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(UpdateJobPositionCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;

        data.Name = request.Name;
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}