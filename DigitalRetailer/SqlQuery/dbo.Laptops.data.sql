--SET IDENTITY_INSERT [dbo].[Laptops] ON
--INSERT INTO [dbo].[Laptops] ([Id], [Name], [Description], [Price], [ImageUrl]) 
--				VALUES (1,
--                 'Hp pavillion',
--                 'RYZEN 5, 1650 GTX, 8 GB RAM',
--					55000,
--                 'img1.png');
--SET IDENTITY_INSERT [dbo].[Laptops] OFF

SET IDENTITY_INSERT [dbo].[Laptops] ON
INSERT INTO [dbo].[Laptops] ([Id], [Name], [Description], [Price], [ImageUrl]) 
				VALUES (2,
                 'Hp Omen',
                 'Intel i5 11th Gen, 16gb RAM, 3050rtx',
					85000,
                 'img2.png'),
				 (3,
                 'Lenovo Ideapad',
                 'Intel i7 11th gen, 2050 RTX, 8 GB RAM, 512GB SSD',
					70000,
                 'img3.png'),
				 (4,
                 'Asus Tuff',
                 'Intel i5 10th gen,1060 gtx, 8 GB RAM, 1TB HDD',
					50000,
                 'img4.png'),
				 (5,
                 'Acer Aspire 7',
                 'Intel i5 12th gen, 1650 gtx, 8 GB RAM, 512GB SSD',
					60000,
                 'img5.png'),
				 (6,
                 'DELL G-15',
                 'Ryzen 5 5600H, 3050 RTX, 16 GB RAM, 512GB SSD',
					75000,
                 'img6.png'),
				 (7,
                 'MSI Alpha 15',
                 'Ryzen 7 5800H,Radeon RX660M, 16 GB RAM, 1TB SSD',
					90000,
                 'img7.png'),
				 (8,
                 'ASUS ROG strix g15',
                 'Ryzen 9 5900H, rtx 3050 Ti, 16 GB RAM, 512GB SSD',
					100000,
                 'img8.png'),
				 (9,
                 'Acer Predator Helios',
                 'Intel i7 11th gen, RTX 3060, 16 GB RAM, 512GB SSD',
					120000,
                 'img9.png');
			
SET IDENTITY_INSERT [dbo].[Laptops] OFF
