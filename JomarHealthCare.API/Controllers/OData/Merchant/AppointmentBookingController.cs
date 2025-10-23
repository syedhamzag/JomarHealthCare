using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using JomarHealthCare.Application.CQRS.AppointmentBookings.Queries;

namespace JomarHealthCare.API.Controllers.OData.Merchant
{
    [Route("odata/merchant")]
    
    public class AppointmentBookingController : ODataController
    {
        private readonly IMediator mediator;

        public AppointmentBookingController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("AppointmentBooking/{id}")]
        [EnableQuery]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var result = await mediator.Send(new GetAppointmentBookingByIdQuery(){ Id=id});
            return Ok(result);
        }

        [HttpGet("AppointmentBookingByCompanyId/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByCompanyIdAsync(Guid key)
        {
            var result = await mediator.Send(new GetAllAppointmentBookingByIdQuery(){ CompanyId = key });
            return Ok(result);
        }
        [HttpGet("AppointmentBooking/GetByAttendeeId/{key}")]
        [EnableQuery]
        public async Task<ActionResult> GetByAttendeeIdAsync(Guid key)
        {
            var result = await mediator.Send(new GetAllAppointmentBookingByAttendeeIdQuery(key));
            return Ok(result);
        }
    }
}
