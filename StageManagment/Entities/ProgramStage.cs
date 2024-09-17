using System.ComponentModel.DataAnnotations;

namespace StageManagment.Entities
{
    public class ProgramStage
    {
        [Key]
        public int ProgramStageId { get; set; }

        [Required, MinLength(3), MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public uint DurationInMinutes { get; set; }

        [Required]
        public decimal PriceInEuro { get; set; }

        public decimal? StartPriceInEuro { get; set; }

        public decimal? EndPriceInEuro { get; set; }

        public bool IsPayd { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        public ICollection<Performance> Performances { get; set; } = new List<Performance>();

        public override string ToString()
        {
            return Name;
        }
    }
}
