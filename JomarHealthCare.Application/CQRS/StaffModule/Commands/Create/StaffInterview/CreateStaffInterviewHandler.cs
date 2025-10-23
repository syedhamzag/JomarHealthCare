using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public partial class CreateStaffInterviewHandler : IRequestHandler<CreateStaffInterviewCommand, StaffInterviewDataModel>
    {
        private readonly IStaffInterviewRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateStaffInterviewHandler(IStaffInterviewRepository repo, IMapper mapper, IUnitOfWork uow, ICompanyRepository companyRepository, IStaffPersonalInfoRepository staffPersonalInfoRepository)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }
        public async Task<StaffInterviewDataModel> Handle(CreateStaffInterviewCommand request, CancellationToken cancellationToken)
        {         
            var entity = _mapper.Map<StaffInterview>(request.DataModel);
            var saved = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffInterviewDataModel>(saved);
        }
    }
}