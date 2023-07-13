CREATE TABLE [dbo].[Rental] (
    [RentalId]       INT           IDENTITY (1, 1) NOT NULL,
    [CustomerId]     INT           NOT NULL,
    [BikeId]         INT           NOT NULL,
    [BorrowDuration] FLOAT (53)    NOT NULL,
    [StaffId]        INT           NOT NULL,
    [CollectionTime] DATETIME2 (7) NOT NULL,
    [ReturnTime]     DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_Rental] PRIMARY KEY CLUSTERED ([RentalId] ASC),
    CONSTRAINT [FK_Rental_Bike_BikeId] FOREIGN KEY ([BikeId]) REFERENCES [dbo].[Bike] ([BikeId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Rental_Customer_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([CustomerId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Rental_Staff_StaffId] FOREIGN KEY ([StaffId]) REFERENCES [dbo].[Staff] ([StaffId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Rental_BikeId]
    ON [dbo].[Rental]([BikeId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Rental_CustomerId]
    ON [dbo].[Rental]([CustomerId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Rental_StaffId]
    ON [dbo].[Rental]([StaffId] ASC);

