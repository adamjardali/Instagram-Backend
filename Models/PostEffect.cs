using System;

namespace Instagram.Models
{
public class PostEffect
{
    public Guid Id { get; init; }
    public Guid PostMediaId { get; init; }
    public Guid EffectId { get; init; }
    public string Scale { get; set; }
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset UpdatedAt { get; set; }       
}
}