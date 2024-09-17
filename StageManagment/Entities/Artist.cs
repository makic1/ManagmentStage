using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManagment.Entities
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }

        [Required, MinLength(2), MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public ArtistCategorie ArtistCategorie { get; set; }

        public ICollection<ProgramStage> ProgramStages { get; set; } = new List<ProgramStage>();


        public override string ToString()
        {
            return Name;
        }
    }

    public enum ArtistCategorie
    {
        Band,
        Musiker,
        Kabatterist,
        Schriftsteller
    }
}
