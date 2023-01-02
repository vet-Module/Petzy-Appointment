using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petzy_Appointment.Model.DataAccess;
using Petzy_Appointment.Model.Entity;

namespace Petzy_Appointment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private IAppointmentRepository repo = new AppointmentRepository();

        [HttpGet]
        public List<Appointment> ListAll()
        {
            return repo.GetAllAppointments();
        }
    }
}
