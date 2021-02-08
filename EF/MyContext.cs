using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EntityModels;

namespace WebApp.EF
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<AuthToken> AuthToken { get; set; }
        public DbSet<GroupChat> GroupChat { get; set; }
        public DbSet<GroupChatMessage> GroupChatMessage { get; set; }
        public DbSet<GroupChatParticipants> GroupChatParticipants { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<PrivateChat> PrivateChat { get; set; }
        public DbSet<PrivateChatMessage> PrivateChatMessage { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<EntityModels.Program> Program { get; set; }
        public DbSet<ProgramDay> ProgramDay { get; set; }
        public DbSet<ProgramDayActivity> ProgramDayActivity { get; set; }
        public DbSet<ProgramProgramDay> ProgramProgramDay { get; set; }
        public DbSet<Activity> Activity { get; set; }
        public DbSet<ActivityAttachment> ActivityAttachment { get; set; }
        public DbSet<ActivityActivityAttachment> ActivityActivityAttachment { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupChatMessage>()
              .HasKey(c => new { c.GroupChatId, c.MessageId });

            modelBuilder.Entity<GroupChatParticipants>()
              .HasKey(c => new { c.GroupChatId, c.UserId });

            modelBuilder.Entity<ProgramProgramDay>()
              .HasKey(c => new { c.ProgramId, c.ProgramDayId });

            modelBuilder.Entity<ProgramDayActivity>()
                .HasKey(c => new { c.ActivityId, c.ProgramDayId });

            modelBuilder.Entity<ActivityActivityAttachment>()
                .HasKey(c => new { c.ActivityId, c.ActivityAttachmentId });
        }
    }
}
