using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagementSystem.Models // ✅ Corrected namespace
{

public class Room
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string RoomNumber { get; set; } = string.Empty;

    [Required]
    public string Name { get; set; } = string.Empty; // Ensure this exists

    [Required]
    public string RoomType { get; set; } = "Standard"; // Deluxe, Suite, Standard

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal PricePerNight { get; set; } = 100.00m;

    // ✅ Added missing ImageUrl property
    public string ImageUrl { get; set; } = "/img/default-room.jpg"; 

    public string Status { get; set; } = "Vacant"; // Vacant, Occupied, Under Maintenance
}
}