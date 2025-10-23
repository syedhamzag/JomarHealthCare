using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateClassOfStaffHandler : IRequestHandler<CreateClassOfStaffCommand, ClassOfStaffDataModel>
    {
        private readonly IClassOfStaffRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateClassOfStaffHandler(IClassOfStaffRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<ClassOfStaffDataModel> Handle(CreateClassOfStaffCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<ClassOfStaff>(request.DataModel);
            var result = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<ClassOfStaffDataModel>(result);
        }
    }
}