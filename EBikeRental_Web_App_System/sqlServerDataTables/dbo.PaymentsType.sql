CREATE TABLE [dbo].[PaymentsType] (
    [PaymentsTypeId] INT            IDENTITY (1, 1) NOT NULL,
    [PaymentType]    NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_PaymentsType] PRIMARY KEY CLUSTERED ([PaymentsTypeId] ASC)
);

