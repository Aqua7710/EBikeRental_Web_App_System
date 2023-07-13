CREATE TABLE [dbo].[Staff] (
    [StaffId]   INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (MAX) NOT NULL,
    [LastName]  NVARCHAR (MAX) NOT NULL,
    [Email]     NVARCHAR (MAX) NOT NULL,
    [Phone]     NVARCHAR (MAX) NOT NULL,
    [Address]   NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED ([StaffId] ASC)
);

