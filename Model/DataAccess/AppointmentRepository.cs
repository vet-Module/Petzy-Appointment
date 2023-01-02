using Petzy_Appointment.Model.Entity;

namespace Petzy_Appointment.Model.DataAccess
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private AppointmentDbContext db = new AppointmentDbContext();
        public List<Appointment> GetAllAppointments()
        {
            return db.Appointments.ToList();
        }
    }
}
