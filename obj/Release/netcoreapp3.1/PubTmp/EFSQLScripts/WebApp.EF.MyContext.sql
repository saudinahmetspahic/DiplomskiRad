IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [Activity] (
        [Id] int NOT NULL IDENTITY,
        [Title] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [ImageName] nvarchar(max) NULL,
        CONSTRAINT [PK_Activity] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [Chat] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Type] int NOT NULL,
        CONSTRAINT [PK_Chat] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [Sponsor] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [ImageName] nvarchar(max) NULL,
        [AreaOfInterest] int NOT NULL,
        CONSTRAINT [PK_Sponsor] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [UserAccount] (
        [Id] int NOT NULL IDENTITY,
        [Salt] nvarchar(max) NULL,
        [Hash] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [Role] int NOT NULL,
        CONSTRAINT [PK_UserAccount] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [ActivityAttachment] (
        [Id] int NOT NULL IDENTITY,
        [TypeOfAttachment] int NOT NULL,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [PriceToVisit] float NOT NULL,
        [ImageName] nvarchar(max) NULL,
        [ActivityId] int NOT NULL,
        CONSTRAINT [PK_ActivityAttachment] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ActivityAttachment_Activity_ActivityId] FOREIGN KEY ([ActivityId]) REFERENCES [Activity] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [Message] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Text] nvarchar(max) NULL,
        [Timestamp] datetime2 NOT NULL,
        [ChatId] int NOT NULL,
        CONSTRAINT [PK_Message] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Message_Chat_ChatId] FOREIGN KEY ([ChatId]) REFERENCES [Chat] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [AuthToken] (
        [ID] int NOT NULL IDENTITY,
        [Value] nvarchar(max) NULL,
        [UserAccountId] int NOT NULL,
        [Date_Created] datetime2 NOT NULL,
        CONSTRAINT [PK_AuthToken] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_AuthToken_UserAccount_UserAccountId] FOREIGN KEY ([UserAccountId]) REFERENCES [UserAccount] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [User] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Surname] nvarchar(max) NULL,
        [City] nvarchar(max) NULL,
        [Country] nvarchar(max) NULL,
        [Age] int NOT NULL,
        [Phone] nvarchar(max) NULL,
        [IsVIP] bit NOT NULL,
        [DateRegistered] datetime2 NOT NULL,
        [UserAccountId] int NOT NULL,
        CONSTRAINT [PK_User] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_User_UserAccount_UserAccountId] FOREIGN KEY ([UserAccountId]) REFERENCES [UserAccount] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [AttachmentAddons] (
        [Id] int NOT NULL IDENTITY,
        [AttachmentId] int NOT NULL,
        [AddonType] int NOT NULL,
        [Distance] int NOT NULL,
        CONSTRAINT [PK_AttachmentAddons] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AttachmentAddons_ActivityAttachment_AttachmentId] FOREIGN KEY ([AttachmentId]) REFERENCES [ActivityAttachment] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [ChatUser] (
        [UserId] int NOT NULL,
        [ChatId] int NOT NULL,
        CONSTRAINT [PK_ChatUser] PRIMARY KEY ([ChatId], [UserId]),
        CONSTRAINT [FK_ChatUser_Chat_ChatId] FOREIGN KEY ([ChatId]) REFERENCES [Chat] ([Id]),
        CONSTRAINT [FK_ChatUser_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [User] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [Notification] (
        [Id] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NOT NULL,
        [Title] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [ImageName] nvarchar(max) NULL,
        [AuthorId] int NOT NULL,
        CONSTRAINT [PK_Notification] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Notification_User_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [User] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [Program] (
        [Id] int NOT NULL IDENTITY,
        [Date_Created] datetime2 NOT NULL,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [CreatorId] int NOT NULL,
        [ProgramAccess] int NOT NULL,
        [ProgramState] int NOT NULL,
        [DateAccessChanged] datetime2 NOT NULL,
        [DateStateChanged] datetime2 NOT NULL,
        CONSTRAINT [PK_Program] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Program_User_CreatorId] FOREIGN KEY ([CreatorId]) REFERENCES [User] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [Rate] (
        [Id] int NOT NULL IDENTITY,
        [ActivityId] int NOT NULL,
        [UserId] int NOT NULL,
        [RateValue] int NOT NULL,
        CONSTRAINT [PK_Rate] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Rate_Activity_ActivityId] FOREIGN KEY ([ActivityId]) REFERENCES [Activity] ([Id]),
        CONSTRAINT [FK_Rate_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [User] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [Feedback] (
        [Id] int NOT NULL IDENTITY,
        [Description] nvarchar(max) NULL,
        [Created] datetime2 NOT NULL,
        [CreatorId] int NOT NULL,
        [ProgramId] int NOT NULL,
        CONSTRAINT [PK_Feedback] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Feedback_Program_ProgramId] FOREIGN KEY ([ProgramId]) REFERENCES [Program] ([Id]),
        CONSTRAINT [FK_Feedback_User_CreatorId] FOREIGN KEY ([CreatorId]) REFERENCES [User] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [ProgramActivity] (
        [Id] int NOT NULL IDENTITY,
        [ProgramId] int NOT NULL,
        [DayOfProgram] int NOT NULL,
        [Start] datetime2 NOT NULL,
        [DedicatedHours] int NOT NULL,
        [ActivityId] int NOT NULL,
        CONSTRAINT [PK_ProgramActivity] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ProgramActivity_Activity_ActivityId] FOREIGN KEY ([ActivityId]) REFERENCES [Activity] ([Id]),
        CONSTRAINT [FK_ProgramActivity_Program_ProgramId] FOREIGN KEY ([ProgramId]) REFERENCES [Program] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [Purchase] (
        [Id] int NOT NULL IDENTITY,
        [DateCreated] datetime2 NOT NULL,
        [CreatorId] int NOT NULL,
        [ProgramId] int NOT NULL,
        CONSTRAINT [PK_Purchase] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Purchase_Program_ProgramId] FOREIGN KEY ([ProgramId]) REFERENCES [Program] ([Id]),
        CONSTRAINT [FK_Purchase_User_CreatorId] FOREIGN KEY ([CreatorId]) REFERENCES [User] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [ProgramActivityAttachment] (
        [Id] int NOT NULL IDENTITY,
        [ProgramActivityId] int NOT NULL,
        [ActivityAttachmentId] int NOT NULL,
        [PlannedStart] datetime2 NOT NULL,
        [PlannedFinish] datetime2 NOT NULL,
        CONSTRAINT [PK_ProgramActivityAttachment] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ProgramActivityAttachment_ActivityAttachment_ActivityAttachmentId] FOREIGN KEY ([ActivityAttachmentId]) REFERENCES [ActivityAttachment] ([Id]),
        CONSTRAINT [FK_ProgramActivityAttachment_ProgramActivity_ProgramActivityId] FOREIGN KEY ([ProgramActivityId]) REFERENCES [ProgramActivity] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [Invoice] (
        [Id] int NOT NULL IDENTITY,
        [Adress] nvarchar(max) NULL,
        [CountryCityPostal] nvarchar(max) NULL,
        [PhoneFax] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [PDVNumber] nvarchar(max) NULL,
        [Customer] nvarchar(max) NULL,
        [CustomerCountry] nvarchar(max) NULL,
        [EstimateNumber] nvarchar(max) NULL,
        [PlaceOfIssue] nvarchar(max) NULL,
        [DateOfIssue] datetime2 NOT NULL,
        [DateOfDelivery] datetime2 NOT NULL,
        [SettledInBAM] float NOT NULL,
        [TotalInWords] nvarchar(max) NULL,
        [MethodOfPayment] nvarchar(max) NULL,
        [DeadlineForPayment] nvarchar(max) NULL,
        [AccountToPay] nvarchar(max) NULL,
        [AdditionalBankAccount] nvarchar(max) NULL,
        [Director] nvarchar(max) NULL,
        [TableRows] int NOT NULL,
        [TableColumns] int NOT NULL,
        [PurchaseId] int NULL,
        CONSTRAINT [PK_Invoice] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Invoice_Purchase_PurchaseId] FOREIGN KEY ([PurchaseId]) REFERENCES [Purchase] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [PurchaseParticipants] (
        [ParticipantId] int NOT NULL,
        [PurchaseId] int NOT NULL,
        CONSTRAINT [PK_PurchaseParticipants] PRIMARY KEY ([ParticipantId], [PurchaseId]),
        CONSTRAINT [FK_PurchaseParticipants_Purchase_PurchaseId] FOREIGN KEY ([PurchaseId]) REFERENCES [Purchase] ([Id]),
        CONSTRAINT [FK_PurchaseParticipants_User_ParticipantId] FOREIGN KEY ([ParticipantId]) REFERENCES [User] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE TABLE [InvoiceTable] (
        [InvoiceId] int NOT NULL,
        [Row] int NOT NULL,
        [Column] int NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_InvoiceTable] PRIMARY KEY ([InvoiceId], [Row], [Column]),
        CONSTRAINT [FK_InvoiceTable_Invoice_InvoiceId] FOREIGN KEY ([InvoiceId]) REFERENCES [Invoice] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_ActivityAttachment_ActivityId] ON [ActivityAttachment] ([ActivityId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_AttachmentAddons_AttachmentId] ON [AttachmentAddons] ([AttachmentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_AuthToken_UserAccountId] ON [AuthToken] ([UserAccountId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_ChatUser_UserId] ON [ChatUser] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_Feedback_CreatorId] ON [Feedback] ([CreatorId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_Feedback_ProgramId] ON [Feedback] ([ProgramId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_Invoice_PurchaseId] ON [Invoice] ([PurchaseId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_Message_ChatId] ON [Message] ([ChatId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_Notification_AuthorId] ON [Notification] ([AuthorId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_Program_CreatorId] ON [Program] ([CreatorId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_ProgramActivity_ActivityId] ON [ProgramActivity] ([ActivityId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_ProgramActivity_ProgramId] ON [ProgramActivity] ([ProgramId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_ProgramActivityAttachment_ActivityAttachmentId] ON [ProgramActivityAttachment] ([ActivityAttachmentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_ProgramActivityAttachment_ProgramActivityId] ON [ProgramActivityAttachment] ([ProgramActivityId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_Purchase_CreatorId] ON [Purchase] ([CreatorId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_Purchase_ProgramId] ON [Purchase] ([ProgramId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_PurchaseParticipants_PurchaseId] ON [PurchaseParticipants] ([PurchaseId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_Rate_ActivityId] ON [Rate] ([ActivityId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_Rate_UserId] ON [Rate] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    CREATE INDEX [IX_User_UserAccountId] ON [User] ([UserAccountId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529135433_m1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210529135433_m1', N'5.0.6');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529153145_m2')
BEGIN
    ALTER TABLE [Invoice] DROP CONSTRAINT [FK_Invoice_Purchase_PurchaseId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529153145_m2')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Invoice]') AND [c].[name] = N'PurchaseId');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Invoice] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Invoice] ALTER COLUMN [PurchaseId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529153145_m2')
BEGIN
    ALTER TABLE [Invoice] ADD CONSTRAINT [FK_Invoice_Purchase_PurchaseId] FOREIGN KEY ([PurchaseId]) REFERENCES [Purchase] ([Id]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210529153145_m2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210529153145_m2', N'5.0.6');
END;
GO

COMMIT;
GO

