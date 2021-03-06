USE [pos]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 4/15/2018 7:16:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[admin](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](200) NULL,
	[password] [varchar](200) NULL,
 CONSTRAINT [PK_admin] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[customers]    Script Date: 4/15/2018 7:16:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[cus_name] [nchar](10) NULL,
	[cus_no] [nchar](10) NULL,
 CONSTRAINT [PK_customers] PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[items]    Script Date: 4/15/2018 7:16:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[items](
	[item_id] [int] IDENTITY(1,1) NOT NULL,
	[item_name] [varchar](100) NULL,
	[item_buy_price] [float] NULL,
	[item_sale_price] [float] NULL,
 CONSTRAINT [PK_items] PRIMARY KEY CLUSTERED 
(
	[item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[orders]    Script Date: 4/15/2018 7:16:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[orders](
	[order_no] [int] IDENTITY(1,1) NOT NULL,
	[item_name] [varchar](50) NULL,
	[item_price] [float] NULL,
	[cus_name] [varchar](50) NULL,
	[invoice_no] [varchar](50) NULL,
	[quantity] [int] NULL,
	[date] [date] NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[order_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[admin] ON 

INSERT [dbo].[admin] ([user_id], [username], [password]) VALUES (1, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[admin] OFF
SET IDENTITY_INSERT [dbo].[customers] ON 

INSERT [dbo].[customers] ([customer_id], [cus_name], [cus_no]) VALUES (2, N'uzair     ', N'021212    ')
INSERT [dbo].[customers] ([customer_id], [cus_name], [cus_no]) VALUES (3, N'ovais     ', N'121212    ')
INSERT [dbo].[customers] ([customer_id], [cus_name], [cus_no]) VALUES (4, N'kamran    ', N'0321212   ')
INSERT [dbo].[customers] ([customer_id], [cus_name], [cus_no]) VALUES (5, N'mam       ', N'021212    ')
SET IDENTITY_INSERT [dbo].[customers] OFF
SET IDENTITY_INSERT [dbo].[items] ON 

INSERT [dbo].[items] ([item_id], [item_name], [item_buy_price], [item_sale_price]) VALUES (1, N'panadol', 120, 280)
INSERT [dbo].[items] ([item_id], [item_name], [item_buy_price], [item_sale_price]) VALUES (2, N'shan', 40, 80)
INSERT [dbo].[items] ([item_id], [item_name], [item_buy_price], [item_sale_price]) VALUES (3, N'sas', 121, 1212)
INSERT [dbo].[items] ([item_id], [item_name], [item_buy_price], [item_sale_price]) VALUES (4, N'lux', 230, 330)
SET IDENTITY_INSERT [dbo].[items] OFF
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([order_no], [item_name], [item_price], [cus_name], [invoice_no], [quantity], [date]) VALUES (17, N'panadol', 240, N'uzair     ', N'B1', 1, CAST(N'2018-01-20' AS Date))
SET IDENTITY_INSERT [dbo].[orders] OFF
