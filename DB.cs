using Project.Models;

namespace Project.SLiddle.Models
{

    public class DB
    {

        public static List<Team> GetTeamList()
        {

            List<Team> teams = new List<Team>
            {
                new Team
                {
                TeamNum = 1,
                TeamName = "Red Bull Racing",
                TeamWChamp = 5,
                SeasonPts = 759,
                Driver1 = "Max Verstappen",
                Driver2 = "Sergio Perez",
                TeamPrinc = "Christian Horner",
                TeamNat = "Austria",
                },
                new Team
                {
                TeamNum = 2,
                TeamName = "Ferrari",
                TeamWChamp = 16,
                SeasonPts = 554,
                Driver1 = "Charles Leclerc",
                Driver2 = "Carlos Sainz",
                TeamPrinc = "Frédéric Vasseur",
                TeamNat = "Italy",
                },
                new Team
                {
                TeamNum = 3,
                TeamName = "Mercedes",
                TeamWChamp = 8,
                SeasonPts = 515,
                Driver1 = "George Russell",
                Driver2 = "Lewis Hamilton",
                TeamPrinc = "Toto Wolff",
                TeamNat = "Germany",
                },
                new Team
                {
                TeamNum = 4,
                TeamName = "Alpine",
                TeamWChamp = 2,
                SeasonPts = 173,
                Driver1 = "Esteban Ocon",
                Driver2 = "Pierre Gasly",
                TeamPrinc = "Otmar Szafnauer",
                TeamNat = "France",
                },
                new Team
                {
                TeamNum = 5,
                TeamName = "Mclaren",
                TeamWChamp = 8,
                SeasonPts = 159,
                Driver1 = "Lando Norris",
                Driver2 = "Oscar Piastri",
                TeamPrinc = "Andrea Stella",
                TeamNat = "United Kingdom",
                },
                new Team
                {
                TeamNum = 6,
                TeamName = "Alfa Romeo",
                TeamWChamp = 0,
                SeasonPts = 55,
                Driver1 = "Valtteri Bottas",
                Driver2 = "Zhou Guanyu",
                TeamPrinc = "Alessandro Alunni Bravi",
                TeamNat = "Switzerland",
                },
                new Team
                {
                TeamNum = 7,
                TeamName = "Aston Martin",
                TeamWChamp = 0,
                SeasonPts = 55,
                Driver1 = "Fernando Alonso",
                Driver2 = "Lance Stroll",
                TeamPrinc = "Mike Krack",
                TeamNat = "United Kingdom",
                },
                new Team
                {
                TeamNum = 8,
                TeamName = "Haas",
                TeamWChamp = 0,
                SeasonPts = 37,
                Driver1 = "Kevin Magnussen",
                Driver2 = "Nico Hulkenberg",
                TeamPrinc = "Guenther Steiner",
                TeamNat = "USA",
                },
                new Team
                {
                TeamNum = 9,
                TeamName = "AlphaTauri",
                TeamWChamp = 0,
                SeasonPts = 35,
                Driver1 = "Yuki Tsunoda",
                Driver2 = "Nyck De Vries",
                TeamPrinc = "Franz Tost",
                TeamNat = "Italy",
                },
                new Team
                {
                TeamNum = 10,
                TeamName = "Williams",
                TeamWChamp = 9,
                SeasonPts = 8,
                Driver1 = "Alexander Albon",
                Driver2 = "Logan Sargeant",
                TeamPrinc = "James Vowles",
                TeamNat = "United Kingdom",

                },
                 
            };
            return teams;
        }

        public static Team GetTeam(int id)
        {
            List<Team> teams = DB.GetTeamList();
            foreach (Team t in teams)
            {
                if (t.TeamNum == id)
                {
                    return t;
                }
            }
            return new Team(); // return empty Team if not in list
        }




    }

}
