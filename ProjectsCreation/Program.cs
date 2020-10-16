using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nameOfTheArchitect = Console.ReadLine();
            
            int countOfProjects = int.Parse(Console.ReadLine());
            int timeNeededForProject = countOfProjects * 3;

            Console.WriteLine($"The architect {nameOfTheArchitect} will need {timeNeededForProject} hours to complete {countOfProjects} project/s.");
        }
    }
}
