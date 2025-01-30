USE [CMSPlus]
GO
SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[Comments](
 [Id] [int] IDENTITY(1,1) NOT NULL,
    [TopicId] [int] NOT NULL,
    [FullName] [nvarchar](50) NOT NULL,
    [Comment] [nvarchar](max) NULL,
    [CreatedOnUtc] [datetime] NOT NULL,
    [UpdatedOnUtc] [datetime] NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
    )
GO
ALTER TABLE [dbo].[Comments] ADD  DEFAULT (getdate()) FOR [CreatedOnUtc]
ALTER TABLE [dbo].[Comments] ADD  DEFAULT (getdate()) FOR [UpdatedOnUtc]

 GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_TopicId] FOREIGN KEY([TopicId])
    REFERENCES [dbo].[Topics] ([Id])
    ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_TopicId]