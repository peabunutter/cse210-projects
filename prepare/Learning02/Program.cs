using System;

Job job1 = new()
{
    _company = "Microsoft",
    _jobTitle = "Software Engineer",
    _startYear = 2000,
    _endYear = 2020
};
Job job2 = new()
{
    _company = "Apple",
    _jobTitle = "Head of Operations",
    _startYear = 1987,
    _endYear = 2019
};
Resume myResume = new()
{
    _name = "Jimothy Anderson"
};

myResume._jobs.Add(job1);
myResume._jobs.Add(job2);

myResume.Display();