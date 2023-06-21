using System;

namespace Instagram.Models
{
public class Post
{
    public Guid Id { get; init; }
    public Guid UserId { get; init; }
    public Guid PostTypeId { get; init; }
    public string Caption { get; set; }
	public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset UpdatedAt { get; set; }
}
}