using StadiumTickets.Shared.Entities;
using System;

namespace StadiumTickets.Api.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckTicketsAsync();
        }

        private async Task CheckTicketsAsync()
        {
            if (!_context.Tickets.Any())
            {
                var ticketList = new List<Ticket>();

                for (int i = 1; i <= 50000; i++)
                {
                    _context.Add(new Ticket
                    {
                        UseDate = null,
                        Used = false,
                        Entrance = null
                    });
                }
                await _context.SaveChangesAsync();
            }
        }
    }
}
