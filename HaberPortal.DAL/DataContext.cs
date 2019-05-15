namespace HaberPortal.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using HaberPortal.Entity;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public virtual DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public virtual DbSet<aspnet_Paths> aspnet_Paths { get; set; }
        public virtual DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }
        public virtual DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        public virtual DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public virtual DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public virtual DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public virtual DbSet<aspnet_UsersInRoles> aspnet_UsersInRoles { get; set; }
        public virtual DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }
        public virtual DbSet<Etiket> Etiket { get; set; }
        public virtual DbSet<Haber> Haber { get; set; }
        public virtual DbSet<HaberTip> HaberTip { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Resim> Resim { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Yazar> Yazar { get; set; }
        public virtual DbSet<Yorum> Yorum { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Membership)
                .WithRequired(e => e.aspnet_Applications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Paths)
                .WithRequired(e => e.aspnet_Applications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Roles)
                .WithRequired(e => e.aspnet_Applications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Paths>()
                .HasOptional(e => e.aspnet_PersonalizationAllUsers)
                .WithRequired(e => e.aspnet_Paths);

            modelBuilder.Entity<aspnet_Roles>()
                .HasMany(e => e.aspnet_UsersInRoles)
                .WithRequired(e => e.aspnet_Roles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventSequence)
                .HasPrecision(19, 0);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventOccurrence)
                .HasPrecision(19, 0);

            modelBuilder.Entity<Etiket>()
                .HasMany(e => e.Haber)
                .WithMany(e => e.Etiket)
                .Map(m => m.ToTable("HaberEtiket").MapLeftKey("EtiketID").MapRightKey("HaberID"));

            modelBuilder.Entity<Haber>()
                .HasMany(e => e.Resim)
                .WithRequired(e => e.Haber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Haber>()
                .HasMany(e => e.Yorum)
                .WithRequired(e => e.Haber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HaberTip>()
                .Property(e => e.Adi)
                .IsFixedLength();

            modelBuilder.Entity<HaberTip>()
                .HasMany(e => e.Haber)
                .WithRequired(e => e.HaberTip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.Haber)
                .WithRequired(e => e.Kategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.Kategori1)
                .WithOptional(e => e.Kategori2)
                .HasForeignKey(e => e.UstKategoriID);

            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.Yazar)
                .WithRequired(e => e.Kategori)
                .WillCascadeOnDelete(false);
        }
    }
}
