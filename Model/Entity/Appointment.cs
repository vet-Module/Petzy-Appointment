namespace Petzy_Appointment.Model.Entity
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        //public TimeOnly Time { get; set; }
        public string Owner { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}

