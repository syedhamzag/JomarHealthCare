using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    internal class StaffPersonalInfoCommandHandler : IRequestHandler<StaffPersonalInfoCommand, OnboardStaffDataModel>
    {
        private readonly IEmailService emailService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IMapper _mapper;
        private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;

        public StaffPersonalInfoCommandHandler(IEmailService emailService, IStaffPersonalInfoRepository staffPersonalInfoRepository, IMapper mapper, IUnitOfWork unitOfWork, IApplicationUserRepository applicationUserRepository)
        {
            this.emailService = emailService;
            _staffPersonalInfoRepository = staffPersonalInfoRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _applicationUserRepository = applicationUserRepository;
        }
        public async Task<OnboardStaffDataModel> Handle(StaffPersonalInfoCommand request, CancellationToken cancellationToken)
        {
            var requestData = request;
            var staffPersonalInfo = _mapper.Map<StaffPersonalInfo>(request.DataModel);
            var result = await _staffPersonalInfoRepository.AddAsync(staffPersonalInfo);
            if (result == null)
            {
                throw new Exception("Failed to onboard staff");
            }
            await _unitOfWork.SaveChangesAsync();
            await emailService.SendEmailAsync(request.DataModel.Email, "Account Creation Successfull", "Staff Account Created Successfully");
            return requestData.DataModel;
        }
    }
}