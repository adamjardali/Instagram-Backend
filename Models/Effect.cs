using System;

namespace Instagram.Models
{
public class Effect
{
    public Guid Id { get; init; }
    public string EffectName { get; set; }
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset UpdatedAt { get; set; }
}
}