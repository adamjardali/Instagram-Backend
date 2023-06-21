using System;

namespace Instagram.Models
{
public class PostMediaUserTag
{
    public Guid Id { get; set; }
    public Guid PostMediaId { get; set; }
    public Guid UserId { get; set; }
    public int XCoordinate { get; set; }
    public int YCoordinate { get; set; }
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset UpdatedAt { get; set; }       
}
}