﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.EF;

namespace WebApp.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("WebApp.EntityModels.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("WebApp.EntityModels.ActivityActivityAttachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ActivityAttachmentId")
                        .HasColumnType("int");

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PlannedFinish")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PlannedStart")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ActivityAttachmentId");

                    b.HasIndex("ActivityId");

                    b.ToTable("ActivityActivityAttachment");
                });

            modelBuilder.Entity("WebApp.EntityModels.ActivityAttachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PriceToVisit")
                        .HasColumnType("float");

                    b.Property<int>("TypeOfAttachment")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.ToTable("ActivityAttachment");
                });

            modelBuilder.Entity("WebApp.EntityModels.AuthToken", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserAccountId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("UserAccountId");

                    b.ToTable("AuthToken");
                });

            modelBuilder.Entity("WebApp.EntityModels.GroupChat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatingTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GroupChat");
                });

            modelBuilder.Entity("WebApp.EntityModels.GroupChatMessage", b =>
                {
                    b.Property<int>("GroupChatId")
                        .HasColumnType("int");

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.HasKey("GroupChatId", "MessageId");

                    b.HasIndex("MessageId");

                    b.ToTable("GroupChatMessage");
                });

            modelBuilder.Entity("WebApp.EntityModels.GroupChatParticipants", b =>
                {
                    b.Property<int>("GroupChatId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("GroupChatId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("GroupChatParticipants");
                });

            modelBuilder.Entity("WebApp.EntityModels.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("MessageContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SendingTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SenderId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("WebApp.EntityModels.PrivateChat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("User1Id")
                        .HasColumnType("int");

                    b.Property<int>("User2Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("User1Id");

                    b.HasIndex("User2Id");

                    b.ToTable("PrivateChat");
                });

            modelBuilder.Entity("WebApp.EntityModels.PrivateChatMessage", b =>
                {
                    b.Property<int>("PrivateChatId")
                        .HasColumnType("int");

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.HasKey("PrivateChatId", "MessageId");

                    b.HasIndex("MessageId");

                    b.ToTable("PrivateChatMessage");
                });

            modelBuilder.Entity("WebApp.EntityModels.Program", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Program");
                });

            modelBuilder.Entity("WebApp.EntityModels.ProgramDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date_Day")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsOver")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfDay")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProgramDay");
                });

            modelBuilder.Entity("WebApp.EntityModels.ProgramDayActivity", b =>
                {
                    b.Property<int>("ActivityAttachmentId")
                        .HasColumnType("int");

                    b.Property<int>("ProgramDayId")
                        .HasColumnType("int");

                    b.HasKey("ActivityAttachmentId", "ProgramDayId");

                    b.HasIndex("ProgramDayId");

                    b.ToTable("ProgramDayActivity");
                });

            modelBuilder.Entity("WebApp.EntityModels.ProgramProgramDay", b =>
                {
                    b.Property<int>("ProgramId")
                        .HasColumnType("int");

                    b.Property<int>("ProgramDayId")
                        .HasColumnType("int");

                    b.HasKey("ProgramId", "ProgramDayId");

                    b.HasIndex("ProgramDayId");

                    b.ToTable("ProgramProgramDay");
                });

            modelBuilder.Entity("WebApp.EntityModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserAccountId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserAccountId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("WebApp.EntityModels.UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserAccount");
                });

            modelBuilder.Entity("WebApp.EntityModels.ActivityActivityAttachment", b =>
                {
                    b.HasOne("WebApp.EntityModels.ActivityAttachment", "ActivityAttachment")
                        .WithMany()
                        .HasForeignKey("ActivityAttachmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.EntityModels.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("ActivityAttachment");
                });

            modelBuilder.Entity("WebApp.EntityModels.ActivityAttachment", b =>
                {
                    b.HasOne("WebApp.EntityModels.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("WebApp.EntityModels.AuthToken", b =>
                {
                    b.HasOne("WebApp.EntityModels.UserAccount", "UserAccount")
                        .WithMany()
                        .HasForeignKey("UserAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("WebApp.EntityModels.GroupChatMessage", b =>
                {
                    b.HasOne("WebApp.EntityModels.GroupChat", "GroupChat")
                        .WithMany()
                        .HasForeignKey("GroupChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.EntityModels.Message", "Message")
                        .WithMany()
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupChat");

                    b.Navigation("Message");
                });

            modelBuilder.Entity("WebApp.EntityModels.GroupChatParticipants", b =>
                {
                    b.HasOne("WebApp.EntityModels.GroupChat", "GroupChat")
                        .WithMany()
                        .HasForeignKey("GroupChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.EntityModels.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupChat");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApp.EntityModels.Message", b =>
                {
                    b.HasOne("WebApp.EntityModels.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("WebApp.EntityModels.PrivateChat", b =>
                {
                    b.HasOne("WebApp.EntityModels.User", "User1")
                        .WithMany()
                        .HasForeignKey("User1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.EntityModels.User", "User2")
                        .WithMany()
                        .HasForeignKey("User2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User1");

                    b.Navigation("User2");
                });

            modelBuilder.Entity("WebApp.EntityModels.PrivateChatMessage", b =>
                {
                    b.HasOne("WebApp.EntityModels.Message", "Message")
                        .WithMany()
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.EntityModels.PrivateChat", "PrivateChat")
                        .WithMany()
                        .HasForeignKey("PrivateChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");

                    b.Navigation("PrivateChat");
                });

            modelBuilder.Entity("WebApp.EntityModels.Program", b =>
                {
                    b.HasOne("WebApp.EntityModels.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("WebApp.EntityModels.ProgramDayActivity", b =>
                {
                    b.HasOne("WebApp.EntityModels.ActivityActivityAttachment", "ActivityAttachment")
                        .WithMany()
                        .HasForeignKey("ActivityAttachmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.EntityModels.ProgramDay", "ProgramDay")
                        .WithMany()
                        .HasForeignKey("ProgramDayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActivityAttachment");

                    b.Navigation("ProgramDay");
                });

            modelBuilder.Entity("WebApp.EntityModels.ProgramProgramDay", b =>
                {
                    b.HasOne("WebApp.EntityModels.ProgramDay", "ProgramDay")
                        .WithMany()
                        .HasForeignKey("ProgramDayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.EntityModels.Program", "Program")
                        .WithMany()
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Program");

                    b.Navigation("ProgramDay");
                });

            modelBuilder.Entity("WebApp.EntityModels.User", b =>
                {
                    b.HasOne("WebApp.EntityModels.UserAccount", "UserAccount")
                        .WithMany()
                        .HasForeignKey("UserAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserAccount");
                });
#pragma warning restore 612, 618
        }
    }
}
