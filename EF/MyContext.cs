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
        //public DbSet<GroupChat> GroupChat { get; set; }
        //public DbSet<GroupChatMessage> GroupChatMessage { get; set; }
        //public DbSet<GroupChatParticipants> GroupChatParticipants { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Chat> Chat { get; set; }
        public DbSet<ChatUser> ChatUser { get; set; }

        //public DbSet<PrivateChat> PrivateChat { get; set; }
        //public DbSet<PrivateChatMessage> PrivateChatMessage { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<EntityModels.Program> Program { get; set; }
        public DbSet<ProgramActivity> ProgramActivity { get; set; }
        public DbSet<ProgramActivityAttachment> ProgramActivityAttachment { get; set; }
        public DbSet<Activity> Activity { get; set; }   
        public DbSet<ActivityAttachment> ActivityAttachment { get; set; }   
        public DbSet<AttachmentAddons> AttachmentAddons { get; set; }
        public DbSet<Notification> Notification { get; set; }

        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<PurchaseParticipants> PurchaseParticipants { get; set; }

        public DbSet<Rate> Rate { get; set; }
        public DbSet<Sponsor> Sponsor { get; set; } 
        public DbSet<Feedback> Feedback { get; set; }    


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PrivateChatMessage>()
            // .HasKey(c => new { c.PrivateChatId, c.MessageId });

            //modelBuilder.Entity<GroupChatMessage>()
            //  .HasKey(c => new { c.GroupChatId, c.MessageId });

            //modelBuilder.Entity<GroupChatParticipants>()    
            //  .HasKey(c => new { c.GroupChatId, c.UserId });

            modelBuilder.Entity<PurchaseParticipants>()
              .HasKey(c => new { c.ParticipantId, c.PurchaseId });

            modelBuilder.Entity<ChatUser>()
             .HasKey(c => new { c.ChatId, c.UserId });
        }
    }
}
