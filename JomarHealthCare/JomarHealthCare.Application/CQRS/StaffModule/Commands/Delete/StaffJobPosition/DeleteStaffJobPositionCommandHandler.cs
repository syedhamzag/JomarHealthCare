using MediatR;
using JomarHealthCare.Application.CQRS.StaffModule.Commands.CommandDtos;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.StaffModule.Commands.Delete.StaffJobPosition;


public class DeleteStaffJobPositionCommandHandler : IRequestHandler<DeleteJobPositionCommand, bool>
{
    private readonly IJobPositionRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteStaffJobPositionCommandHandler(IJobPositionRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteJobPositionCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        _repository.Delete(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
