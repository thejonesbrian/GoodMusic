using GoodMusic.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace GoodMusic.Data
{
    public class GoodMusicDbContext : DbContext
    {
        public GoodMusicDbContext(){}
        public GoodMusicDbContext(DbContextOptions options) : base(options) { }
        
        public virtual DbSet<Music> Music { get; set; }
        public virtual DbSet<MusicReview> MusicReviews { get; set; }
    }
}
