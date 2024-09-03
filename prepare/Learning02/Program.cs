using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Harlequin Rabbit breeder";
        job1._company = "Lyra Lagamorphes";
        job1._startYear = 2021;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Rhinelander Rabbit breeder";
        job2._company = "Rhinelander Rabbitry";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Evangeline Lily";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}