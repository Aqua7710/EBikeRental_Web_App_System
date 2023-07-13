CREATE TABLE [dbo].[Customer] (
    [CustomerId]       INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]        NVARCHAR (MAX) NOT NULL,
    [LastName]         NVARCHAR (MAX) NOT NULL,
    [Phone]            NVARCHAR (MAX) NOT NULL,
    [Email]            NVARCHAR (MAX) NOT NULL,
    [Address]          NVARCHAR (MAX) NOT NULL,
    [Dob]              DATETIME2 (7)  NOT NULL,
    [BikeRentalActive] BIT            NULL,
    [PaymentId]        INT            NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerId] ASC),
    CONSTRAINT [FK_Customer_Payment_PaymentId] FOREIGN KEY ([PaymentId]) REFERENCES [dbo].[Payment] ([PaymentId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Customer_PaymentId]
    ON [dbo].[Customer]([PaymentId] ASC);

