using JomarHealthCare.Application.CQRS.SendRota.Commands;
using JomarHealthCare.Application.CQRS.SendRota.Queries;
using JomarHealthCare.Application.DataModels.SendRota;

namespace JomarHealthCare.API.Controllers.API.Merchant.CareManagement;

[Route("api/[controller]")]
[ApiController]
public class StaffRotaController : ControllerBase
{
    private readonly IMediator _mediator;
    public StaffRotaController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpPost("StaffRotaPreview")]
    public async Task<ActionResult<List<StaffRotaPreviewDataModel>>> StaffRotaPreview([FromBody] List<RotaPreviewDataModel> model)
    {
        var result = await _mediator.Send(new GetStaffRotaPreviewQuery(model));
        return Ok(result);
    }

    [HttpPost("StaffRotaMedicationPreview")]
    public async Task<ActionResult<List<MedTrackerDataModel>>> StaffRotaMedicationPreview([FromBody] List<RotaPreviewDataModel> model)
    {
        var result = await _mediator.Send(new GetStaffMedRotaPreviewQuery(model));
        return Ok(result);
    }


    [HttpPost("CreateStaffRota")]
    public async Task<IActionResult> CreateStaffRota([FromBody] List<RotaPreviewDataModel> model)
    {
        var result = await _mediator.Send(new CreateStaffRotaCommand(model));
        return Ok(result);
    }

    [HttpPost("MedicationLiveTracker")]
    public async Task<ActionResult<List<StaffRotaPreviewDataModel>>> MedicationLiveTracker([FromBody] GetRotaByDateDataModel model)
    {
        var result = await _mediator.Send(new GetLiveMedicationTracker(model));
        return Ok(result);
    }

    [HttpPost("LiveTracker")]
    public async Task<ActionResult<List<LiveTracker>>> LiveTracker([FromBody] GetRotaByDateDataModel model)
    {
        var result = await _mediator.Send(new GetLiveTracker(model));
        return Ok(result);
    }
    [HttpPost("LiveTrackerByConcern")]
    public async Task<ActionResult<List<LiveTracker>>> LiveTrackerByConcern([FromBody] GetRotaByConcernDateDataModel model)
    {
        var result = await _mediator.Send(new GetLiveTrackerConcern(model));
        return Ok(result);
    }

    [HttpPost("ClockIn")]
    public async Task<ActionResult<List<LiveTracker>>> ClockIn([FromBody] StaffRotaClockInDto model)
    {
        var result = await _mediator.Send(new StaffRotaClockInCommand(model));
        return Ok(result);
    }


    [HttpPost("ClockOut")]
    public async Task<ActionResult<List<LiveTracker>>> ClockOut([FromBody] StaffRotaClockOutDto model)
    {
        var result = await _mediator.Send(new StaffRotaClockOutCommand(model));
        return Ok(result);
    }
}
