using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.ServiceTypes.Commands;


public class AddServiceTypeCommandHandler : IRequestHandler<AddServiceTypeCommand, ServiceType>
{
    private readonly IServiceTypeRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public AddServiceTypeCommandHandler(IServiceTypeRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<ServiceType> Handle(AddServiceTypeCommand request, CancellationToken cancellationToken)
    {
        var data = new ServiceType
        {
            Name = request.Name,
            CompanyId = request.CompanyId
        };

        await _repository.AddAsync(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return data;
    }
}