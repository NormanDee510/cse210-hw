using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job
        {
            _jobTitle = "Software Engineer",
            _company = "Cortexware",
            _startYear = 2019,
            _endYear = 2022
        };

        Job job2 = new Job
        {
            _jobTitle = "Manager",
            _company = "Andiccio24",
            _startYear = 2022,
            _endYear = 2023
        };

        Resume myResume = new Resume
        {
            _name = "Newman Demba"
        };

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}