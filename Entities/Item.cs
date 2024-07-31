using System.ComponentModel.DataAnnotations.Schema;
using AuctionService.Entities;

namespace AuctionService.Item;

[Table("Items")]
public class AuctionItem
{
    public Guid Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public int Mileage { get; set; }
    public string ImageUrl { get; set; }

    // nav properties
    public Auction Auction { get; set; }
    public Guid AuctionId   { get; set; }
}