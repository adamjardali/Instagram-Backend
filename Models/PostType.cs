using System;

namespace Instagram.Models
{
public class PostType
{
    public Guid Id { get; init; }
    public PostTypeEnum Type { get; set; }
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset UpdatedAt { get; set; }       
    public enum PostTypeEnum
    {
        PHOTO,
        VIDEO,
        CAROUSEL,
        STORIES,
        REELS
    }
}
}