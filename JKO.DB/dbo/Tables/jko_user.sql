CREATE TABLE [dbo].[jko_user] (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [user_name] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_jko_user] PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [u_jko_user_user_name]
    ON [dbo].[jko_user]([user_name] ASC);

