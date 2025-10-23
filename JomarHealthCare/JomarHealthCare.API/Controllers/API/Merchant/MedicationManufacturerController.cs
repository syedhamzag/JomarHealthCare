using JomarHealthCare.Application.CQRS.MedicationManufacturers.Command;
using JomarHealthCare.Application.CQRS.MedicationManufacturers.Query;

namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/merchant/[controller]")]
    [ApiController]
    public class MedicationManufacturerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MedicationManufacturerController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new MedicationManufacturerQuery());
            return Ok(result);
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _mediator.Send(new GetMedicationManaufacturerByIdQuery(id));
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateMedicationManufacturerCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);  
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateMedicationManufacturerCommand command)
        {
            var result = await _mediator.Send(command);
            return result ? NoContent() : NotFound();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteMedicationManufacturerCommand { MedicationManufacturerId = id });
            return result ? NoContent() : NotFound();
        }
    }
}
