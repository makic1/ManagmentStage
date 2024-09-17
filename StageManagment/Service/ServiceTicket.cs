using StageManagment.Entities;

namespace StageManagment.Service
{
    public class ServiceTicket
    {
        private readonly DbContextStageManagment _context;

        public ServiceTicket(DbContextStageManagment context)
        {
            _context = context;
        }

        // todo: inline kommentare
        public List<Ticket> GetAllTickets()
        {
            return _context.Tickets.ToList();
        }

        public void AddTicket(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }

        public void UpdateTicket(Ticket ticketToUpdate)
        {
            var ticket = FindTicketById(ticketToUpdate.TicketId);

            if (ticket is not null)
            {
                ticket.TicketId = ticketToUpdate.TicketId;
                ticket.SeatRow = ticketToUpdate.SeatRow;
                ticket.SeatNumber = ticketToUpdate.SeatNumber;
                ticket.PriceInEuro = ticketToUpdate.PriceInEuro;
                ticket.PaydPriceInEuro = ticketToUpdate.PaydPriceInEuro;
                ticket.CustomerFirstname = ticketToUpdate.CustomerFirstname;
                ticket.CustomerLastname = ticketToUpdate.CustomerLastname;
                ticket.CustomerCategorie = ticketToUpdate.CustomerCategorie;
                ticket.CustomerAddress = ticketToUpdate.CustomerAddress;
                ticket.CustomerCountry = ticketToUpdate.CustomerCountry;
                ticket.CustomerPLZ = ticketToUpdate.CustomerPLZ;
                ticket.PerformanceId = ticketToUpdate.PerformanceId;

                _context.SaveChanges();
            }
        }

        public void RemoveTicketById(int id)
        {
            _context.Tickets.Remove(FindTicketById(id));
            _context.SaveChanges();
        }

        public Ticket FindTicketById(int id)
        {
            return _context.Tickets.Find(id);
        }

        public bool CheckForDuplicateTickets(Ticket ticket)
        {
            return _context.Tickets.Any(t => t.SeatRow == ticket.SeatRow && t.SeatNumber == ticket.SeatNumber && t.PerformanceId == ticket.PerformanceId);
        }
    }
}
