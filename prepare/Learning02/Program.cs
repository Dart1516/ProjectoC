using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Sitel";
        job1._job_title = "Team Leader";
        job1._start_year = 2022;
        job1._end_year = 2023;
        

        Job job2 = new Job();
        job2._company = "Atento";
        job2._job_title = "Team Leader";
        job2._start_year = 2019;
        job2._end_year = 2022;
        

        Resume resume1 = new Resume();
        resume1._persons_name = "David Puche";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.DisplayResume();
    }
}