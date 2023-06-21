using System;

namespace Instagram.Models
{
public class Filter
{
    public Guid Id { get; init; }
    public string FilterName { get; set; }
    public string FilterDetails { get; set; }
    public DateTimeOffset DateCreated { get; init; }
    public DateTimeOffset UpdatedAt { get; set; }
}
}