using JomarHealthCare.Application.CQRS.Medications.Commands;
using JomarHealthCare.Application.CQRS.Medications.Queries;

namespace JomarHealthCare.API.Controllers.API.Merchant;

[Route("api/merchant/[controller]")]
[ApiController]
public class MedicationController : ControllerBase
{
    private readonly IMediator _mediator;
    public MedicationController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateMedicationCommand command)
    {
        var medication = await _mediator.Send(command);
        return Ok(medication);
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateMedicationCommand command)
    {
        var result = await _mediator.Send(command);
        return result ? NoContent() : NotFound();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteMedicationCommand { MedicationId = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new GetAllMedicationQuery());
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _mediator.Send(new GetMedicationByIdQuery(id));
        if (result == null)
            return NotFound();
        return Ok(result);
    }
}
