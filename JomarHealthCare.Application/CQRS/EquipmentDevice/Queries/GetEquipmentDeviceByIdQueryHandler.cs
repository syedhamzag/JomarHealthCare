using MediatR;
using JomarHealthCare.Application.DataModels.EquipmentAssess;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Application.ResponseModels;

namespace JomarHealthCare.Application.CQRS.EquipmentDevice.Queries;


internal class GetEquipmentDeviceByIdQueryHandler
    : IRequestHandler<GetEquipmentDeviceByIdQuery, DefaultResponse<EquipmentDeviceDataViewModel>>
{
    private readonly IEquipmentAssessmentDataRepository _repository;

    public GetEquipmentDeviceByIdQueryHandler(IEquipmentAssessmentDataRepository repository)
    {
        _repository = repository;
    }

    public async Task<DefaultResponse<EquipmentDeviceDataViewModel>> Handle(GetEquipmentDeviceByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByEquipmentAssessId(request.Id);

        if (entity == null)
        {
            return new DefaultResponse<EquipmentDeviceDataViewModel>
            {
                Status = false,
                ResponseCode = "404",
                ResponseMessage = "Equipment not found",
                Data = null
            };
        }

        var viewModel = new EquipmentDeviceDataViewModel
        {
            Id = entity.Id,
            EquipmentAssessmentId = entity.EquipmentAssessmentId,
            URL = entity.URL,
            HowToUse = entity.HowToUse,
            ClientRisk = entity.ClientRisk,
            StaffRisk = entity.StaffRisk,
            Image = entity.Image
        };

        return new DefaultResponse<EquipmentDeviceDataViewModel>
        {
            Status = true,
            ResponseCode = "200",
            ResponseMessage = "Success",
            Data = viewModel
        };
    }
}