using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._JobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2025;
        job1._endYear = 2030;

        Job job2 = new Job();

        job2._JobTitle = "Front End Developer";
        job2._company = "SpaceX";
        job2._startYear = 2025;
        job2._endYear = 2030;

        Resume Myself = new Resume();
        Myself._name = "Dillan S Torres";
        Myself._jobs.Add(job1);
        Myself._jobs.Add(job2);

        Myself.DisplayResume();
    }
}