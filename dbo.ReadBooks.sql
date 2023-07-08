CREATE TABLE [dbo].[ReadBooks] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [BookId]  INT            NOT NULL,
    [UserId]  NVARCHAR (450) NOT NULL,
    --[Author] NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_ReadBooks] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ReadBooks_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ReadBooks_Books_BookId] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Books] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_ReadBooks_BookId]
    ON [dbo].[ReadBooks]([BookId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ReadBooks_UserId]
    ON [dbo].[ReadBooks]([UserId] ASC);

	