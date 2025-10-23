using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.AreaCodes.Commands;

public class AddAreaCodeCommandHandler : IRequestHandler<AddAreaCodeCommand, AreaCode>
{
    private readonly IAreaCodeRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public AddAreaCodeCommandHandler(IAreaCodeRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<AreaCode> Handle(AddAreaCodeCommand request, CancellationToken cancellationToken)
    {
        var data = new AreaCode
        {
            Name = request.Name,
            CompanyId = request.CompanyId
        };

        await _repository.AddAsync(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return data;
    }
}