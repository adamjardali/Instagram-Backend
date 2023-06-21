using System;

namespace Instagram.Models
{
public class PostMedia
{
    public Guid Id { get; init; }
    public Guid PostId { get; init; }
    public Guid FilterId { get; init; }
    public string MediaFileUrl { get; set; }
    public int Position { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset UpdatedAt { get; set; }       
}
}