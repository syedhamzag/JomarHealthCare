using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Hobby.Commands;

public class AddHobbyCommandHandler : IRequestHandler<AddHobbyCommand, Hobbies>
{
    private readonly IHobbyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public AddHobbyCommandHandler(IHobbyRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<Hobbies> Handle(AddHobbyCommand request, CancellationToken cancellationToken)
    {
        var data = new Hobbies
        {
            Name = request.Name,
            Description = request.Description,
            CompanyId = request.CompanyId
        };

        await _repository.AddAsync(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return data;
    }
}