using Microsoft.Identity.Client.Extensibility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManagment.Entities
{
    public class Performance
    {
        [Key]
        public int PerformanceId { get; set; }

        [Required, MinLength(1), MaxLength(60)]
        public string Name { get; set; }

        [Required]
        public DateTime StartPerformance { get; set; }

        [Required]
        public DateTime EndPerformance { get; set; }

        public bool IsActive { get; set; }

        public int ProgramStageId { get; set; }
        public ProgramStage ProgramStage { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

        public override string ToString()
        {
            return Name;
        }
    }
}
