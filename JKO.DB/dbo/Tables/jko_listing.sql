CREATE TABLE [dbo].[jko_listing] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [title]       NVARCHAR (100) NOT NULL,
    [description] NVARCHAR (100) NOT NULL,
    [price]       INT            NOT NULL,
    [user_id]     INT            NOT NULL,
    [create_time] DATETIME2 (7)  CONSTRAINT [DF_jko_listing_create_time] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_jko_listing] PRIMARY KEY CLUSTERED ([id] ASC)
);

