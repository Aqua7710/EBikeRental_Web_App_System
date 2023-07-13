SET IDENTITY_INSERT [dbo].[Bike] ON
INSERT INTO [dbo].[Bike] ([BikeId], [BikeModel], [BikeSpecs], [StockQuantity], [CostPerDay]) VALUES (1002, N'Giant 2022 Talon E+', N'Colour: Blue Ashes, Weight: 23 KG, Battery: EnergyPak 400Wh, Top Speed: 32KM/H', 10, CAST(95.99 AS Decimal(18, 2)))
INSERT INTO [dbo].[Bike] ([BikeId], [BikeModel], [BikeSpecs], [StockQuantity], [CostPerDay]) VALUES (1003, N'Liv 2022 Tempt E+', N'Colour: GUNMETAL BLACK, Weight: 18.5 KG, Battery: EnergyPak 400Wh, Top Speed: 32KM/H', 7, CAST(95.99 AS Decimal(18, 2)))
INSERT INTO [dbo].[Bike] ([BikeId], [BikeModel], [BikeSpecs], [StockQuantity], [CostPerDay]) VALUES (1004, N'Trek 2023', N'Colour: MATTE DNISTER BLACK, Weight: 19.93 KG, Battery: TQ 360Wh, Top Speed: 32KM/H', 3, CAST(129.99 AS Decimal(18, 2)))
INSERT INTO [dbo].[Bike] ([BikeId], [BikeModel], [BikeSpecs], [StockQuantity], [CostPerDay]) VALUES (1005, N'Whyte Bikes 2023', N'Colour: Matte Black, Weight: 25.78 KG, Battery: 750Wh, Top Speed: 30KM/H', 4, CAST(129.99 AS Decimal(18, 2)))
INSERT INTO [dbo].[Bike] ([BikeId], [BikeModel], [BikeSpecs], [StockQuantity], [CostPerDay]) VALUES (1006, N'Magnum E-bikes Metro S', N'Colour: Black, Weight: 26.8 KG, Battery: Long Ranged 624Wh, Top Speed: 32KM/H', 13, CAST(79.99 AS Decimal(18, 2)))
INSERT INTO [dbo].[Bike] ([BikeId], [BikeModel], [BikeSpecs], [StockQuantity], [CostPerDay]) VALUES (1007, N'Trek 2022 Rail 5 Deore E-Bike', N'Colour: Matte Black, Weight: 23.88 KG, Battery: Bosch PowerTube 500Wh, Top Speed: 32KM/H', 8, CAST(129.99 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Bike] OFF
