
namespace Project.Models
{
    public class Team
    {

        public int TeamNum { get; set; }
        public int TeamWChamp { get; set; }
        public int SeasonPts { get; set; }
        public string TeamName { get; set; } = string.Empty;
        public string Driver1 { get; set; } = string.Empty;
        public string Driver2 { get; set; } = string.Empty;
        public string TeamPrinc { get; set; } = string.Empty;
        public string TeamNat { get; set; } = string.Empty;
    }
}

