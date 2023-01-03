using System;
using System.Collections.Generic;

namespace DoctorAssignmentApplication
{
    public class AppointmentManager
    {
        public List<DoctorInfo> Doctors { get; set; }
        public List<PatientInfo> Patients { get; set; }
        public List<AppointmentInfo> Appointments { get; set; }

        public AppointmentManager(List<DoctorInfo> doctors,List<PatientInfo> patients,List<AppointmentInfo> appointments)
        {
            Doctors=doctors;
            Patients=patients;
            Appointments=appointments;
        }
    }
}