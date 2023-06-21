using System;

namespace Instagram.Models
{
public class Comment
{
    public Guid Id { get; init; }
    public Guid UserId { get; init; }
    public Guid PostId { get; init; }
    public Guid? CommentRepliedTo { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset UpdatedAt { get; set; }
    public string CommentText { get; set; }
}
}