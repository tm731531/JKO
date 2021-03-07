CREATE TABLE [dbo].[jko_listing] (
    [id]          INT            IDENTITY (100001, 1) NOT NULL,
    [title]       NVARCHAR (100) NOT NULL,
    [description] NVARCHAR (100) NOT NULL,
    [price]       INT            NOT NULL,
    [user_name]   VARCHAR (100)  NOT NULL,
    [category]    VARCHAR (100)  NOT NULL,
    [is_deleted]  BIT            CONSTRAINT [DF_jko_listing_is_deleted] DEFAULT ((0)) NOT NULL,
    [create_time] DATETIME2 (7)  CONSTRAINT [DF_jko_listing_create_time] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_jko_listing] PRIMARY KEY CLUSTERED ([id] ASC)
);










GO
CREATE NONCLUSTERED INDEX [i_jko_listing_isdeleted_username]
    ON [dbo].[jko_listing]([is_deleted] ASC, [user_name] ASC);

