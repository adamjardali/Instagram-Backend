using Microsoft.EntityFrameworkCore;
using Instagram.Models;

namespace Instagram.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<PostType> PostType { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<Effect> Effects { get; set; }
        public DbSet<Follower> Followers { get; set; }
        public DbSet<PostMedia> PostMedia { get; set; }
        public DbSet<PostEffect> PostEffects { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public DbSet<PostMediaUserTag> PostMediaUserTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>(entity =>
            {   
                entity.HasKey(e => e.Id);

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.Email).IsRequired().HasMaxLength(255);

                entity.Property(e => e.UserName).IsRequired().HasMaxLength(255);

                entity.Property(e => e.Bio).IsRequired();

                entity.Property(e => e.CountryCode).IsRequired();

                entity.Property(e => e.PhoneNumber).IsRequired();

                entity.Property(e => e.ProfilePicture).IsRequired();

                entity.Property(e => e.CreatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);

                entity.Property(e => e.UpdatedAt).IsRequired();

                entity.HasIndex(e => e.Email).IsUnique();

                entity.HasIndex(e => e.UserName).IsUnique();
            });

            modelBuilder.Entity<PostType>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.CreatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);

                entity.Property(e => e.UpdatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);

                entity.Property(e => e.Type).IsRequired();

                entity.Property(e => e.Type).HasConversion<string>();

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Type).HasConversion(v => v.ToString(),v => (PostType.PostTypeEnum)Enum.Parse(typeof(PostType.PostTypeEnum), v));
            });

             modelBuilder.Entity<Post>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.UserId).IsRequired();

                entity.Property(e => e.PostTypeId).IsRequired();

                entity.Property(e => e.Caption);

                entity.Property(e => e.CreatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);

                entity.Property(e => e.UpdatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);;

                entity.HasOne<User>().WithMany().HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne<PostType>().WithMany().HasForeignKey(e => e.PostTypeId).OnDelete(DeleteBehavior.Restrict);
                entity.HasIndex(e => new { e.CreatedAt, e.UpdatedAt }).IsUnique();
            });

            modelBuilder.Entity<Filter>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.FilterName).IsRequired();

                entity.Property(e => e.FilterDetails).IsRequired();

                entity.Property(e => e.DateCreated).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);

                entity.Property(e => e.UpdatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);
            });

            modelBuilder.Entity<Effect>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.EffectName).IsRequired();

                entity.Property(e => e.CreatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);

                entity.Property(e => e.UpdatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);
            });

            modelBuilder.Entity<Follower>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.FollowerId).IsRequired();

                entity.Property(e => e.FollowingId).IsRequired();

                entity.Property(e => e.CreatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);

                entity.Property(e => e.UpdatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);

                entity.HasOne<User>().WithMany().HasForeignKey(e => e.FollowerId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne<User>().WithMany().HasForeignKey(e => e.FollowingId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PostMedia>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.PostId).IsRequired();

                entity.Property(e => e.FilterId).IsRequired();

                entity.Property(e => e.MediaFileUrl).IsRequired();

                entity.Property(e => e.Position).IsRequired();

                entity.Property(e => e.Longitude).IsRequired();

                entity.Property(e => e.Latitude).IsRequired();

                entity.Property(e => e.CreatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);

                entity.Property(e => e.UpdatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);

                entity.HasOne<Post>().WithMany().HasForeignKey(e => e.PostId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne<Filter>().WithMany().HasForeignKey(e => e.FilterId).OnDelete(DeleteBehavior.Restrict);

                entity.HasIndex(e => new { e.FilterId, e.PostId }).IsUnique();
            });

            modelBuilder.Entity<PostEffect>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.PostMediaId).IsRequired();

                entity.Property(e => e.EffectId).IsRequired();

                entity.Property(e => e.Scale).IsRequired();

                entity.Property(e => e.CreatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);

                entity.Property(e => e.UpdatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);

                entity.HasOne<PostMedia>().WithMany().HasForeignKey(e => e.PostMediaId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne<Effect>().WithMany().HasForeignKey(e => e.EffectId).OnDelete(DeleteBehavior.Restrict);

                entity.HasIndex(e => new { e.PostMediaId, e.EffectId }).IsUnique();
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.UserId).IsRequired();
                entity.Property(e => e.PostId).IsRequired();
                entity.Property(e => e.CommentText).IsRequired();

                entity.Property(e => e.CreatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);
                entity.Property(e => e.UpdatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);

                entity.HasOne<User>().WithMany().HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne<Post>().WithMany().HasForeignKey(e => e.PostId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne<Comment>().WithMany().HasForeignKey(e => e.CommentRepliedTo).OnDelete(DeleteBehavior.Restrict);

                entity.HasIndex(e => new { e.UserId, e.PostId, e.CommentRepliedTo }).IsUnique();
            });

            modelBuilder.Entity<Reaction>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.UserId).IsRequired();
                entity.Property(e => e.PostId).IsRequired();

                entity.Property(e => e.CreatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);
                entity.Property(e => e.UpdatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);

                entity.HasOne<User>().WithMany().HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne<Post>().WithMany().HasForeignKey(e => e.PostId).OnDelete(DeleteBehavior.Restrict);

                entity.HasIndex(e => new { e.UserId, e.PostId }).IsUnique();
            });

            modelBuilder.Entity<PostMediaUserTag>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.PostMediaId).IsRequired();
                entity.Property(e => e.UserId).IsRequired();

                entity.Property(e => e.CreatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);
                entity.Property(e => e.UpdatedAt).IsRequired().HasDefaultValue(DateTimeOffset.UtcNow);

                entity.HasOne<PostMedia>().WithMany().HasForeignKey(e => e.PostMediaId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne<User>().WithMany().HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);

                entity.HasIndex(e => new { e.PostMediaId, e.UserId }).IsUnique();
            });


        }
    }
}
