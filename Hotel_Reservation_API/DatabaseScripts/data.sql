SET IDENTITY_INSERT [dbo].[ReservationDetails] ON
INSERT INTO [dbo].[ReservationDetails] ([Id], [Name], [ContactNumber], [HotelName], [PricePerRoom], [ReservationDate]) VALUES (1, N'Raj', N'258963258', N'Taj', CAST(250.00 AS Decimal(18, 2)), N'2020-05-05 12:00:00')
INSERT INTO [dbo].[ReservationDetails] ([Id], [Name], [ContactNumber], [HotelName], [PricePerRoom], [ReservationDate]) VALUES (2, N'Balraj', N'456789654', N'Obroy', CAST(120.00 AS Decimal(18, 2)), N'2020-05-05 12:00:00')
SET IDENTITY_INSERT [dbo].[ReservationDetails] OFF
