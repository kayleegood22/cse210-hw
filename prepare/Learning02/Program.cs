using System;

class Program
{

    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Janitor";
        job1._company = "BYU-Idaho";
        job1._startYear = 2021;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Teacher";
        job2._company = "BYU-Hawaii";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Bob Ross";

        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);

        myResume.Display();
    }

    

}