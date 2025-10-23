using JomarHealthCare.Application.CQRS.MedicationRoutes.Command;
using JomarHealthCare.Application.CQRS.MedicationRoutes.Queries;

namespace JomarHealthCare.API.Controllers.API.Merchant
{
    [Route("api/merchant/[controller]")]
    [ApiController]
    public class MedicationRouteController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MedicationRouteController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new MedicationRouteQuery());
            return Ok(result);
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _mediator.Send(new MedicationRouteByIdQuery(id));
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateMedicationRouteCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateMedicationRouteCommand command)
        {
            var result = await _mediator.Send(command);
            return result ? NoContent() : NotFound();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteMedicationRouteCommand { MedicationRouteId = id });
            return result ? NoContent() : NotFound();
        }


    }
}
