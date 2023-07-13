CREATE TABLE [dbo].[Payment] (
    [PaymentId]      INT             IDENTITY (1, 1) NOT NULL,
    [TotalCost]      DECIMAL (18, 2) NOT NULL,
    [PaymentsTypeId] INT             NOT NULL,
    [PaymentDate]    DATETIME2 (7)   NULL,
    [PaymentStatus]  BIT             NOT NULL,
    CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED ([PaymentId] ASC),
    CONSTRAINT [FK_Payment_PaymentsType_PaymentsTypeId] FOREIGN KEY ([PaymentsTypeId]) REFERENCES [dbo].[PaymentsType] ([PaymentsTypeId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Payment_PaymentsTypeId]
    ON [dbo].[Payment]([PaymentsTypeId] ASC);

