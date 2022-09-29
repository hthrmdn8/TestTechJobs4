using System;
using System.Collections.Generic;
using TestTechJobs4.Models;

namespace TestTechJobs4.Models
{
    public class Job
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Employer Employer { get; set; }

        public int EmployerId { get; set; }

        public List<JobSkill> JobSkills { get; set; }

        public Job()
        {
        }

        public Job(string name)
        {
            Name = name;
        }
    }
}