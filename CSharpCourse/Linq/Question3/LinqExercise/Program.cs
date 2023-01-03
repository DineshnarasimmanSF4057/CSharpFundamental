using System.Runtime.Intrinsics.X86;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can get the trainee details from the GetTraineeDetails() method in TraineeData class
            Console.WriteLine("Enter Menu Number");
            int option = Convert.ToInt32(Console.ReadLine());
            TraineeDetails obj = new TraineeDetails();
            TraineeData ob1 = new TraineeData();
            List<TraineeDetails> traineeList = ob1.GetTraineeDetails();
            

            switch(option)
            {
                case 1:
                    {
                        IEnumerable<string> result= from trainee in traineeList select trainee.TraineeId;
                        foreach(string id in result)
                        {
                            System.Console.WriteLine(id);
                        }
                        break;
                    }
                case 2:
                    {
                        IEnumerable<string> result=(from trainee in traineeList select trainee.TraineeId).Take(3);
                       
                        foreach(string id in result)
                        {
                            System.Console.WriteLine(id);
                        }
                        break;
                    }
                case 3:
                    {
                        IEnumerable<string> result=(from trainee in traineeList select trainee.TraineeId).Skip(3);
                        foreach(string id in result)
                        {
                            System.Console.WriteLine(id);
                        }
                        break;
                    }  
                case 4:
                    {
                        IEnumerable<string> result= from trainee in traineeList select trainee.TraineeId;
                        System.Console.WriteLine(result.Count());
                        break;
                    }
                case 5:
                    {
                        IEnumerable<string> result=from trainee in traineeList where trainee.YearPassedOut>=2019 select trainee.TraineeName;
                        foreach(string name in result)
                        {
                            System.Console.WriteLine(name);
                        }
                        break;
                    }
                case 6:
                    {
                        IEnumerable<TraineeDetails> traineeName=traineeList.OrderBy(c=>c.TraineeName);
                        foreach(TraineeDetails name in traineeName)
                        {
                            System.Console.WriteLine(name.TraineeId+ " - "+name.TraineeName);
                        }
                        break;
                    }
                case 7:
                    {
                        IEnumerable<TraineeDetails> details=from trainee in traineeList where trainee.ScoreDetails[0].Mark>=4 select trainee;
                        foreach(TraineeDetails trainees in details)
                        {
                            System.Console.WriteLine($"{trainees.TraineeId} | {trainees.TraineeName} | {trainees.DOJ} | {trainees.YearPassedOut}");
                        }
                        break;
                    }
                case 8:
                    {
                        IEnumerable<int> years=(from trainee in traineeList select trainee.YearPassedOut).Distinct();
                        foreach(int year in years)
                        {
                            System.Console.WriteLine(year);
                        }
                        break;
                    }
                case 9:
                    {
                        System.Console.WriteLine("Enter Trainee ID");
                        string userTraineeID=Console.ReadLine();

                        IEnumerable<int> detail=from trainee in traineeList where userTraineeID==trainee.TraineeId select trainee.TotalScore; 
                        if(detail.Count()!=0)
                        {
                            foreach(int mark in detail)
                            {
                                System.Console.WriteLine(mark);
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid ID");
                        }

                        break;
                    }
                case 10:
                    {
                        TraineeDetails info=traineeList.First();
                        System.Console.WriteLine(info.TraineeId+ "-"+ info.TraineeName);
                        break;
                    }
                case 11:
                    {
                        TraineeDetails info=traineeList.Last();
                        System.Console.WriteLine(info.TraineeId+ "-"+ info.TraineeName);
                        break;
                    }
                case 12:
                    {
                        IEnumerable<int> mark=from trainee in traineeList select trainee.TotalScore;
                        foreach(int marks in mark)
                        {
                            System.Console.WriteLine(marks);
                        }
                        break;                      
                    }
                case 13:
                    {
                        int mark=(from trainee in traineeList select trainee.TotalScore).Max();
                        System.Console.WriteLine(mark);
                        break;
                    }
                case 14:
                    {
                        int mark=(from trainee in traineeList select trainee.TotalScore).Min();
                        System.Console.WriteLine(mark);
                        break;
                    }
                case 15:
                    {
                        double average=(from trainee in traineeList select trainee.TotalScore).Average();
                        System.Console.WriteLine(average);
                        break;
                    }
                case 16:
                    {   
                        bool finalResult=(from trainee in traineeList select trainee).Any(trainee=>trainee.TotalScore>40);
                        System.Console.WriteLine(finalResult);
                        break;
                    }
                case 17:
                    {
                        bool finalResult=(from trainee in traineeList select trainee).All(trainee=>trainee.TotalScore>40);
                        System.Console.WriteLine(finalResult);
                        break;
                    }
                case 18:
                    {
                        IEnumerable<TraineeDetails> details=traineeList.OrderByDescending(c=>c.TraineeName).OrderByDescending(c=>c.TotalScore);

                        foreach(TraineeDetails info in details)
                        {
                            System.Console.WriteLine($"{info.TraineeId} | {info.TraineeName} | {info.DOJ} | {info.YearPassedOut}");
                        }
                        break;
                    }
            }
           
        }
    }
}
