using System;
using System.Collections.Generic;
using System.Text;

namespace DatetimePractice
{
    class Hospital
    {
        public List<Appointment> Appointments = new List<Appointment>();
        
        public void AddAppointment(Appointment appointment)
        {
            Appointments.Add(appointment);
        }

        public void EndAppointment(int no)
        {
            Appointment appointment = Appointments.Find(x => x.No == no);

            appointment.EndDate = DateTime.Now;

            Console.WriteLine(appointment.EndDate); 
        }

        public Appointment GetAppointment(int no)
        {
            Appointment app = Appointments.Find(x => x.No == no);
            Console.WriteLine($"{app.Patient} - {app.Doctor} - {app.StartDate}");
            return app;
        }

        public List<Appointment> GetAllAppointments()
        {
            foreach (var item in Appointments)
            {
                Console.WriteLine($"{item.Patient} - {item.Doctor} - {item.StartDate}");
            }
            return Appointments;
        }

        public List<Appointment> GetWeeklyAppointments()
        {
            List<Appointment>newApps = Appointments.FindAll(x => x.StartDate < DateTime.Now && x.StartDate > DateTime.Now.Date.AddDays(-7));
            foreach (var item in newApps)
            {
                Console.WriteLine($"{item.Patient} - {item.Doctor} - {item.StartDate}");
            }
            return newApps;
        }

        public List<Appointment> GetTodaysAppointments()
        {
            List<Appointment>newApps = Appointments.FindAll(x => x.StartDate == DateTime.Now);
            foreach (var item in newApps)
            {
                Console.WriteLine($"{item.Patient} - {item.Doctor} - {item.StartDate}");
            }
            return newApps;
        }

        public List<Appointment> GetContinuingAppointments()
        {
            List<Appointment>newApps = Appointments.FindAll(x => x.EndDate.Year == 0001);
            foreach (var item in newApps)
            {
                Console.WriteLine($"{item.Patient} - {item.Doctor} - {item.StartDate}");
            }
            return newApps;
        }


    }
}
