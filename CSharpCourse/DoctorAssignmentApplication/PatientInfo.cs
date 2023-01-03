namespace DoctorAssignmentApplication
{
    public enum Gender{Select,Male,Female}
    public class PatientInfo
    {
        private static int s_patientID;
        public string PatientID { get;}
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public PatientInfo(string name,string password,int age,Gender gender)
        {
            s_patientID++;
            PatientID=$"PID{s_patientID}";
            Name=name;
            Password=password;
            Age=age;
            Gender=gender;
        }
    }
}