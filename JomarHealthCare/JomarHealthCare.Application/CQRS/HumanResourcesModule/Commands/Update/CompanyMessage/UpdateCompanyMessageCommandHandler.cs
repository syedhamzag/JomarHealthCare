using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public class UpdateCompanyMessageCommandHandler : IRequestHandler<UpdateCompanyMessageCommand, bool>
{
    private readonly ICompanyMessageRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public UpdateCompanyMessageCommandHandler(ICompanyMessageRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<bool> Handle(UpdateCompanyMessageCommand request, CancellationToken cancellationToken)
    {
        var entity = await _repo.Get(x => x.Id == request.DataModel.Id).FirstOrDefaultAsync();
        if (entity == null) throw new KeyNotFoundException($"CompanyMessage with ID {request.DataModel.Id} not found.");

        _mapper.Map(request.DataModel, entity);
        _repo.Update(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return true;
    }
}
}
