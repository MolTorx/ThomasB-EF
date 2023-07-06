using System.ComponentModel.DataAnnotations.Schema;

namespace DinoWebAPI
{
    public class Dinosaur
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public string Diet { get; set; } = string.Empty;
        public string Era { get; set; } = string.Empty;
        public int WheightInTons { get; set; } = 8;

        [Column(TypeName = "nvarchar (40)")]
        public string CurrentContinent { get; set; } = null!;
        
    }
}