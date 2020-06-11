using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            Dictionary<string, string> toStringDict = new Dictionary<string, string>();
            toStringDict.Add("ID", $"{Id}");
            toStringDict.Add("Name", Name);
            toStringDict.Add("Employer", EmployerName.ToString());
            toStringDict.Add("Location", EmployerLocation.ToString());
            toStringDict.Add("Position Type", JobType.ToString());
            toStringDict.Add("Core Competency", JobCoreCompetency.ToString());

            string toStringStr = "\n";

            foreach (string key in toStringDict.Keys)
            {
                toStringStr += $"{key}: {toStringDict[key]}\n";
            }

            //return $"\nID: {Id}\nName: {Name}\nEmployer: {EmployerName.ToString()}\nLocation: {EmployerLocation.ToString()}\nPosition Type: {JobType.ToString()}\nCore Competency: {JobCoreCompetency.ToString()}\n";
            return toStringStr;
        }
    }
}
