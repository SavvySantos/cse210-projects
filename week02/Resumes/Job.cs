public class Job
    {
        public string _jobTitle;
        public string _company;
        public string _startYear;
        public string _endYear;
        public string _jobs;
        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
        }
    }
    
