using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            var teams = ReadTeams(numberOfTeams);
            PrintTeams(teams);
        }

        public static void PrintTeams(List<Team> teams)
        {
            var disbandTeams = teams.Where(m => !m.Members.Any());
            foreach (var team in teams.Where(m=>m.Members.Any()))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- {0}", team.Creator);

                foreach (var member in team.Members)
                {
                    Console.WriteLine(member);
                }
            }
            if(disbandTeams.Any())
            {
                Console.WriteLine("Teams to disband:");
                foreach (var team in disbandTeams)
                {
                    Console.WriteLine(team.Name);
                }
            }
        }

        public static List<Team> ReadTeams(int numberOfTeams)
        {
            List<Team> teams = new List<Team>();
            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] inputArgs = Console.ReadLine().Split('-');
                string creator = inputArgs[0];
                string teamName = inputArgs[1];
                var team = teams.FirstOrDefault(m => m.Name == teamName);
                if(team == null)
                {
                    teams.Add(new Team(teamName, creator, new List<string>()));
                    Console.WriteLine("Team {0} has been created by {1}", teamName, creator);
                }
                else
                {
                    Console.WriteLine("Team {0} was already created!", teamName);
                }
            }
            string command = Console.ReadLine();
            while (!command.Equals("end of assignment"))
            {
                string[] inputArgs = command.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string member = inputArgs[0];
                string teamName = inputArgs[1];
                var team = teams.FirstOrDefault(m => m.Name == teamName);
                if (team == null)
                {
                    Console.WriteLine("Team {0} does not exist!", teamName);
                }
                else
                {
                    if(!team.Members.Contains(member))
                    {
                        team.Members.Add(member);
                    }
                }
                command = Console.ReadLine();
            }

            return teams.OrderBy(m=>m.Name).ToList();
        }
    }
}
