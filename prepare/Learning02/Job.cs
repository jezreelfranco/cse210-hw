using System;
using System.Collections.Generic;

// PART ONE: create the syntax'
namespace ca1050
{
    public class Job
    {
        public string _companyName = "";
        public string _jobTitle = "";
        public int _startYear;
        public int _endYear;

        public Job()
        {
        }

        public void ShowJobInformation()
        {
            Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
        }
    }
}

// public class Resume
// {
//     public string _name = "";
//     public List<Jobs> _jobs = new List<Jobs>();
    
// }