CREATE TABLE [dbo].[Bike] (
    [BikeId]        INT             IDENTITY (1, 1) NOT NULL,
    [BikeModel]     NVARCHAR (MAX)  NOT NULL,
    [BikeSpecs]     NVARCHAR (MAX)  NOT NULL,
    [StockQuantity] FLOAT (53)      NOT NULL,
    [CostPerDay]    DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Bike] PRIMARY KEY CLUSTERED ([BikeId] ASC)
);

