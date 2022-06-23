using System;

namespace DatetimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            string input;
            do
            {
                Console.WriteLine("\n1.Appointment yarat:");
                Console.WriteLine("2.Appointmenti bitir:");
                Console.WriteLine("3.Butun appointmentlere bax:");
                Console.WriteLine("4.Bu hefteki ppointmentlere bax:");
                Console.WriteLine("5.Bugwnki appointmentlere bax:");
                Console.WriteLine("6.Bitmemis appointmentlere bax:");
                Console.WriteLine("7.Menudan cix:");
                Console.WriteLine("\n Seciminizi edin");
                input = Console.ReadLine();


                switch (input)
                {
                    case "1":
                        hospital.AddAppointment(CreateAppointment());
                        break;
                    case "2":
                        hospital.EndAppointment(GetNoFromConsole());
                        break;
                    case "3":
                        hospital.GetAllAppointments();
                       
                        break;
                    case "4":
                        hospital.GetWeeklyAppointments();
                     
                        break;
                    case "5":
                        hospital.GetTodaysAppointments();
                       
                        break;
                    case "6":
                        hospital.GetContinuingAppointments();
                        
                        break;
                  
                }

            } while (input != "7");




            static Appointment CreateAppointment()
            {
                Console.WriteLine("Muraciet eden:");
                string patient = Console.ReadLine();

                Console.WriteLine("Muraciet etdiyi hekim:");
                string doctor = Console.ReadLine();


                string noStr;
                int no;
                do
                {
                    Console.WriteLine("Xestenin nomresi:");
                    noStr = Console.ReadLine();
                } while (!int.TryParse(noStr, out no) || no < 0);

                string startDateStr;
                DateTime startDate;
                do
                {
                    Console.WriteLine("Gorusun baslama vaxti:");
                    startDateStr = Console.ReadLine();
                } while (!DateTime.TryParse(startDateStr, out startDate));                
                string endDateStr;
                DateTime endDate;

                Appointment appointment = new Appointment
                {
                    Doctor = doctor,
                    No = no,
                    Patient = patient,
                    StartDate = startDate
                };

                return appointment;
            }

            static int GetNoFromConsole()
            {
                string noStr;
                int no;
                do
                {
                    Console.WriteLine("Pasientin nomresini daxil edin");
                    noStr = Console.ReadLine();
                } while (!int.TryParse(noStr, out no));

                return no;
            }

            
        }
    }
}
