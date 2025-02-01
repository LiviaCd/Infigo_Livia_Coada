USE [CMSPlus]
GO
SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
UPDATE [dbo].[Comments] 
SET [Comment] = '' 
WHERE [Comment] IS NULL;

ALTER TABLE [dbo].[Comments] 
ALTER COLUMN [Comment] [nvarchar](max) NOT NULL;
