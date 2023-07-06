using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DinoWebAPI
{
    public class ReptileVol
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        
        [Key]
        [Column(Order=1)]
        public int Size { get; set; }
        
    }
}