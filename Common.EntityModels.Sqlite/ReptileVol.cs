using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DinoWebAPI
{
    [PrimaryKey(nameof(Size), nameof(WheightInTons))]
    public class ReptileVol
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        
        [Key]
        [Column(Order = 1)]
        public int Size { get; set; }
        [Key]
        [Column(Order = 2)]
        public int WheightInTons { get; set; }

        public virtual List<ReptileMar> Children { get; set; } = null!;
        
    }
}