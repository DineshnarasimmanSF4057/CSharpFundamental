using System.Collections.Generic;
namespace DoctorAssignmentApplication
{
    public class DoctorInfo
    {
        private static int s_doctorID;
        public string DoctorID { get;  }
        public string DoctorName { get; set; }
        public string Department { get; set; }
        
        public DoctorInfo(string doctorName,string department)
        {
            s_doctorID++;
            DoctorID=$"DID{s_doctorID}";
            DoctorName=doctorName;
            Department=department;
            
        }
    }
}