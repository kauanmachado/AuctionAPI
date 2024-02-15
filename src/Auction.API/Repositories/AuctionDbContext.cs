using NLWAuction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace NLWAuction.API.Repositories;

public class AuctionDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
}
