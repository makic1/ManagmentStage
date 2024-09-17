using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManagment.Entities
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        [Required]
        public SeatRow SeatRow { get; set; }

        [Required]
        public int SeatNumber {  get; set; }

        [Required]
        public decimal PriceInEuro { get; set; }

        public decimal? PaydPriceInEuro { get; set; }

        [MinLength(3), MaxLength(50)]
        public string? CustomerFirstname { get; set; }

        [MinLength(3), MaxLength(50)]
        public string? CustomerLastname { get; set; }

        public CustomerCategorie? CustomerCategorie { get; set; }

        [MinLength(5), MaxLength(60)]
        public string? CustomerAddress { get; set; }

        [MinLength(2), MaxLength(60)]
        public string? CustomerCountry { get; set; }
        public int? CustomerPLZ { get; set; }


        public int PerformanceId { get; set; }
        public Performance Performance { get; set; }
    }

    public enum SeatRow
    {
        A, B, C, D, E, F, G, H, I, J, K
    }

    public enum CustomerCategorie
    {
        NichtVerkauft,
        Normal,
        Student,
        Schueler,
        Pensionist
    }
}
