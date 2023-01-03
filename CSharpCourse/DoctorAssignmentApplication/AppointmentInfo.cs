using System;
namespace DoctorAssignmentApplication
{
    public enum Status {select,Booked,Cancelled}
    public class AppointmentInfo
    {
        private static int s_appointmentID;
        public string AppointmentID { get; }
        public string DoctorID { get; set; }
        public string PatientID { get; set; }
        public DateTime Date { get; set; }
        public string AppointmentSlots{get;set;}
        public string Problem { get; set; }
        public Status Status { get; set; }

        public AppointmentInfo(string doctorID,string patientID,DateTime date,string problem,Status status)
        {
            s_appointmentID++;
            AppointmentID=$"AID{s_appointmentID}";
            DoctorID=doctorID;
            PatientID=patientID;
            Date=date;
            Problem=problem;
            Status=status;
        }
    }
}