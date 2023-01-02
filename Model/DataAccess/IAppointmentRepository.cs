using Petzy_Appointment.Model.Entity;

namespace Petzy_Appointment.Model.DataAccess
{
    public interface IAppointmentRepository
    {
        List<Appointment> GetAllAppointments();
    }
}
