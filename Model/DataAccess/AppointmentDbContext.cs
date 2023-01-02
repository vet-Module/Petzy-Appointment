using Microsoft.EntityFrameworkCore;
using Petzy_Appointment.Model.Entity;

namespace Petzy_Appointment.Model.DataAccess
{
    public class AppointmentDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=PetzyAppointmentDb;Integrated Security=True");
        }


        public DbSet<Appointment> Appointments { get;set; }
    }


}
