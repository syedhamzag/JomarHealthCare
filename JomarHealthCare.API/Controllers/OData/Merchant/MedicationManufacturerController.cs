using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using JomarHealthCare.Application.CQRS.MedicationManufacturers.Query;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    [Authorize(Policy = My360AuthorizationPolicy.Company)]
    public class MedicationManufacturerController : ODataController
    {
        private readonly IMediator _mediator;
        public MedicationManufacturerController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("MedicationManufacturer")]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<MedicationManufacturer>>> GetAllAsync()
        {
            var result = await _mediator.Send(new MedicationManufacturerQuery());
            return Ok(result);
        }



        [HttpGet("MedicationManufacturer({key})")]
        [EnableQuery]
        public async Task<ActionResult<MedicationManufacturer>> GetByIdAsync(int key)
        {
            var result = await _mediator.Send(new GetMedicationManaufacturerByIdQuery(key));
            return Ok(result);
        }
    }
}
