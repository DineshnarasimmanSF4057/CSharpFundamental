using System.Linq;
using System.Collections.Generic;
using System;
namespace DoctorAssignmentApplication
{
    public class Operation
    {
        static List<DoctorInfo> doctorList = new List<DoctorInfo>();
        static List<AppointmentInfo> appointmentList = new List<AppointmentInfo>();
        static List<PatientInfo> patientsList = new List<PatientInfo>();
        static List<Departments> departmentsList = new List<Departments>();
        static PatientInfo currentPatient;

        public static void MainMenu()
        {
            int option;
            do
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Main Menu");
                System.Console.WriteLine();
                System.Console.WriteLine("1.Login\n2.Registration\n3.Exit");
                System.Console.WriteLine();
                System.Console.WriteLine("Select a option");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            System.Console.WriteLine("Login");
                            Login();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("Registration");
                            Registration();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Exit");
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("Invalid option");
                            break;
                        }
                }


            } while (option != 3);
        }
        public static void Registration()
        {
            System.Console.WriteLine("Registration starts");
            System.Console.WriteLine();
            System.Console.WriteLine("Enter the following Details");
            System.Console.WriteLine();
            System.Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            System.Console.WriteLine("Enter yout father name");
            string fatherName = Console.ReadLine();

            System.Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your gender info");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

            System.Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            PatientInfo patient = new PatientInfo(name, password, age, gender);

            System.Console.WriteLine($"Your Registration is successfull. your Patient ID is {patient.PatientID}");
            patientsList.Add(patient);

        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your patient ID");
            string userPatientID = Console.ReadLine().ToUpper();

            bool condition = true;
            bool condition3 = true;
            foreach (PatientInfo patientInfo in patientsList)
            {
                if (patientInfo.PatientID == userPatientID)
                {
                    condition = false;
                    System.Console.WriteLine("Enter your password");
                    string userPassword = Console.ReadLine();

                    if (patientInfo.Password == userPassword)
                    {
                        condition3 = false;
                        System.Console.WriteLine("Successfully Logged In");
                        currentPatient = patientInfo;
                        Submenu();

                    }
                }
            }
            if (condition)
            {
                System.Console.WriteLine("Invalid patient ID");
            }
            else
            {
                if (condition3)
                {
                    System.Console.WriteLine("Invalid Password");
                }
            }
        }
        public static void Submenu()
        {
            int option;
            do
            {
                System.Console.WriteLine("1.Book Appointment\n2.View Application Detail\n3.Edit My Profile\n4.Exit");
                System.Console.WriteLine();
                System.Console.WriteLine("Enter a option");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            System.Console.WriteLine("Book Appointment");
                            BookAppointment();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("View Application Detail");
                            AppointmentInfo();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Edit My profile");
                            EditProfile();
                            break;
                        }
                    case 4:
                        {
                            System.Console.WriteLine("Exit");
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("Invalid Entry");
                            break;
                        }
                }
            } while (option != 4);
        }
        public static void BookAppointment()
        {
            foreach (Departments departmentsInfo in departmentsList)
            {
                System.Console.WriteLine($"{departmentsInfo.DepartmentName}");
            }
            System.Console.WriteLine("Enter the department with correct spelling");
            string userDepartment = Console.ReadLine();

            System.Console.WriteLine("Enter your Problem");
            string problem=Console.ReadLine();
            
            bool condition = true;
            foreach (Departments departmentsInfo in departmentsList)
            {
                if (departmentsInfo.DepartmentName == userDepartment)
                {
                    condition = false;
                }
            }
            if (condition)
            {
                System.Console.WriteLine("Invalid Department");
            }
            else
            {
                foreach (DoctorInfo doctorInfo in doctorList)
                {
                    if (doctorInfo.Department == userDepartment)
                    {
                        System.Console.WriteLine($"{doctorInfo.DoctorID} | {doctorInfo.DoctorName} | {doctorInfo.Department} ");
                    }
                }

                System.Console.WriteLine("Enter Doctor ID: ");
                string doctorID = Console.ReadLine().ToUpper();

                System.Console.WriteLine("Enter Appointment Date in (dd/MM/yyyy)  ");
                DateTime appointmentDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);


                bool conditionCheck=true;
                foreach (DoctorInfo doctorInfo in doctorList)
                {
                    if (doctorInfo.Department == userDepartment && doctorInfo.DoctorID==doctorID)
                    {
                        conditionCheck = false;
                        bool condition1 = true;
                        foreach (AppointmentInfo appointmentInfo in appointmentList)
                        {
                            
                            
                                if (appointmentDate == appointmentInfo.Date && appointmentInfo.Status == Status.Booked)
                                {
                                    condition1 = false;
                                    break;
                                }
                            
                        }
                        if (!condition1)
                        {
                            System.Console.WriteLine("Slot not available");
                        }
                        if (condition1)
                        {
                            bool check = true;
                                    if (appointmentDate >= DateTime.Now)
                                    {
                                        check = false;
                                        AppointmentInfo appointment1 = new AppointmentInfo(doctorInfo.DoctorID, currentPatient.PatientID, appointmentDate,problem , Status.Booked);
                                        appointmentList.Add(appointment1);
                                        System.Console.WriteLine("Booked successfully");
                                    }
                                
                            if (check)
                            {
                                System.Console.WriteLine("Invalid slot");
                            }
                        }
                    }
                }
                if(conditionCheck)
                {
                    System.Console.WriteLine("Invalid DoctorID");
                }

            }
        }
        public static void AppointmentInfo()
        {
            bool condition = true;
            foreach (AppointmentInfo appointmentInfo in appointmentList)
            {
                if (appointmentInfo.PatientID == currentPatient.PatientID)
                {
                    condition = false;
                    System.Console.WriteLine($"{appointmentInfo.AppointmentID} | {appointmentInfo.PatientID} | {appointmentInfo.DoctorID} | {appointmentInfo.Date.ToString("dd/MM/yyyy")} | {appointmentInfo.AppointmentSlots} | {appointmentInfo.Status}");
                }
            }
            if (condition)
            {
                System.Console.WriteLine("NO appointments founf");
            }
        }
        public static void EditProfile()
        {
            System.Console.WriteLine("Name: ");
            currentPatient.Name=Console.ReadLine();
            
            System.Console.WriteLine("Password: ");
            currentPatient.Password=Console.ReadLine();
            
            System.Console.WriteLine("Age: ");
            currentPatient.Age=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Gender: ");
            currentPatient.Gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        }
        public static void DefaultData()
        {
           

            DoctorInfo doctor1 = new DoctorInfo("Nancy","Anaesthesiology");
            DoctorInfo doctor2 = new DoctorInfo("Andrew","Cardiology");
            DoctorInfo doctor3 = new DoctorInfo("Janet","Diabetology");
            DoctorInfo doctor4 = new DoctorInfo("Margaret","Neonatology");
            DoctorInfo doctor5 = new DoctorInfo("Steven","Nephrology");



            doctorList.Add(doctor1);
            doctorList.Add(doctor2);
            doctorList.Add(doctor3);
            doctorList.Add(doctor4);
            doctorList.Add(doctor5);

            Departments department1=new Departments("Anaesthesiology");
            Departments department2=new Departments("Cardiology");
            Departments department3=new Departments("Diabetology");
            Departments department4=new Departments("Neonatology");
            Departments department5=new Departments("Nephrology");
            departmentsList.Add(department1);
            departmentsList.Add(department2);
            departmentsList.Add(department3);
            departmentsList.Add(department4);
            departmentsList.Add(department5);


            PatientInfo patient1 = new PatientInfo("Robert","Rob",33, Gender.Male);
            PatientInfo patient2 = new PatientInfo("Anne","Welcome", 23, Gender.Female);
            PatientInfo patient3 = new PatientInfo("Laura","Incorrect" ,36, Gender.Female);
           
            patientsList.Add(patient1);
            patientsList.Add(patient2);
            patientsList.Add(patient3);

            
            AppointmentInfo appointment1 = new AppointmentInfo(doctor1.DoctorID, patient1.PatientID, new DateTime(2022, 12, 25),"Heart Problem", Status.Booked);
            AppointmentInfo appointment2 = new AppointmentInfo(doctor2.DoctorID, patient2.PatientID, new DateTime(2022, 12, 26),"Spinal Cord Injury",  Status.Booked);
            AppointmentInfo appointment3 = new AppointmentInfo(doctor3.DoctorID, patient3.PatientID, new DateTime(2022, 12, 29), "Heart Attack",Status.Booked);
            

            appointmentList.Add(appointment1);
            appointmentList.Add(appointment2);
            appointmentList.Add(appointment3);
            
        }
    }
}
