USE [HotelManagementSystem]
GO
/****** Object:  Table [dbo].[Checkin]    Script Date: 4/25/2024 3:23:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Checkin](
	[checkin_id] [int] IDENTITY(1,1) NOT NULL,
	[room_id] [int] NOT NULL,
	[guest_id] [int] NOT NULL,
	[checkin_date] [datetime] NOT NULL,
	[checkout_date] [datetime] NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_date] [datetime] NOT NULL,
	[is_deleted] [smallint] NOT NULL,
 CONSTRAINT [PK_Checkin] PRIMARY KEY CLUSTERED 
(
	[checkin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 4/25/2024 3:23:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[employee_id] [int] IDENTITY(1,1) NOT NULL,
	[full_name] [nvarchar](100) NOT NULL,
	[phone_number] [nvarchar](50) NOT NULL,
	[position] [nvarchar](50) NOT NULL,
	[nrc_number] [nvarchar](50) NOT NULL,
	[dob] [datetime] NOT NULL,
	[gender] [smallint] NOT NULL,
	[image] [nvarchar](255) NULL,
	[joined_date] [datetime] NOT NULL,
	[address] [nvarchar](255) NULL,
	[created_userId] [int] NOT NULL,
	[updated_userId] [int] NOT NULL,
	[deleted_userId] [int] NULL,
	[created_date] [datetime] NOT NULL,
	[updated_date] [datetime] NOT NULL,
	[is_deleted] [smallint] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guest]    Script Date: 4/25/2024 3:23:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guest](
	[guest_id] [int] IDENTITY(1,1) NOT NULL,
	[full_name] [nvarchar](100) NOT NULL,
	[phone_number] [nvarchar](50) NOT NULL,
	[nationality] [nvarchar](50) NOT NULL,
	[nrc_number] [nvarchar](50) NOT NULL,
	[dob] [datetime] NOT NULL,
	[gender] [smallint] NOT NULL,
	[address] [nvarchar](255) NULL,
	[created_date] [datetime] NOT NULL,
	[updated_date] [datetime] NOT NULL,
	[is_deleted] [smallint] NOT NULL,
 CONSTRAINT [PK_Guest] PRIMARY KEY CLUSTERED 
(
	[guest_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 4/25/2024 3:23:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[payment_id] [int] IDENTITY(1,1) NOT NULL,
	[checkin_id] [int] NOT NULL,
	[room_fees] [decimal](10, 2) NOT NULL,
	[extra_fees] [decimal](10, 2) NOT NULL,
	[description] [nvarchar](255) NULL,
	[discount] [decimal](10, 2) NOT NULL,
	[total_fees] [decimal](10, 2) NOT NULL,
	[payment_type] [nvarchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_date] [datetime] NOT NULL,
	[is_deleted] [smallint] NOT NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[payment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 4/25/2024 3:23:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[reservation_id] [int] IDENTITY(1,1) NOT NULL,
	[room_id] [int] NOT NULL,
	[room_number] [nvarchar](50) NOT NULL,
	[checkin_date] [datetime] NOT NULL,
	[checkout_date] [datetime] NOT NULL,
	[customer_name] [nvarchar](100) NOT NULL,
	[customer_phoneNo] [nvarchar](50) NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_date] [datetime] NOT NULL,
	[is_deleted] [smallint] NOT NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[reservation_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 4/25/2024 3:23:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[room_id] [int] IDENTITY(1,1) NOT NULL,
	[room_no] [nvarchar](50) NOT NULL,
	[room_type] [nvarchar](50) NOT NULL,
	[is_occupied] [smallint] NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_date] [datetime] NOT NULL,
	[is_deleted] [smallint] NOT NULL,
	[room_price] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[room_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 4/25/2024 3:23:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](100) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[role] [smallint] NOT NULL,
	[created_date] [datetime] NOT NULL,
	[updated_date] [datetime] NOT NULL,
	[is_deleted] [smallint] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Checkin] ADD  CONSTRAINT [DF_Checkin_is_deleted]  DEFAULT ((0)) FOR [is_deleted]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_is_deleted]  DEFAULT ((0)) FOR [is_deleted]
GO
ALTER TABLE [dbo].[Guest] ADD  CONSTRAINT [DF_Guest_is_deleted]  DEFAULT ((0)) FOR [is_deleted]
GO
ALTER TABLE [dbo].[Payment] ADD  CONSTRAINT [DF_Payment_extra_fees]  DEFAULT ((0)) FOR [extra_fees]
GO
ALTER TABLE [dbo].[Payment] ADD  CONSTRAINT [DF_Payment_discount]  DEFAULT ((0)) FOR [discount]
GO
ALTER TABLE [dbo].[Payment] ADD  CONSTRAINT [DF_Payment_is_deleted]  DEFAULT ((0)) FOR [is_deleted]
GO
ALTER TABLE [dbo].[Reservation] ADD  CONSTRAINT [DF_Reservation_is_deleted]  DEFAULT ((0)) FOR [is_deleted]
GO
ALTER TABLE [dbo].[Room] ADD  CONSTRAINT [DF_Room_is_occupied]  DEFAULT ((0)) FOR [is_occupied]
GO
ALTER TABLE [dbo].[Room] ADD  CONSTRAINT [DF_Room_is_deleted]  DEFAULT ((0)) FOR [is_deleted]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_is_deleted]  DEFAULT ((0)) FOR [is_deleted]
GO
ALTER TABLE [dbo].[Checkin]  WITH CHECK ADD  CONSTRAINT [FK_Checkin_Guest] FOREIGN KEY([guest_id])
REFERENCES [dbo].[Guest] ([guest_id])
GO
ALTER TABLE [dbo].[Checkin] CHECK CONSTRAINT [FK_Checkin_Guest]
GO
ALTER TABLE [dbo].[Checkin]  WITH CHECK ADD  CONSTRAINT [FK_Checkin_Room] FOREIGN KEY([room_id])
REFERENCES [dbo].[Room] ([room_id])
GO
ALTER TABLE [dbo].[Checkin] CHECK CONSTRAINT [FK_Checkin_Room]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Checkin] FOREIGN KEY([checkin_id])
REFERENCES [dbo].[Checkin] ([checkin_id])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Checkin]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Room] FOREIGN KEY([room_id])
REFERENCES [dbo].[Room] ([room_id])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Room]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0:Other, 1:Male, 2:Female' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'gender'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0:NotDeleted, 1:Deleted' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'is_deleted'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0:NotDeleted, 1:Deleted' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Guest', @level2type=N'COLUMN',@level2name=N'is_deleted'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0:NotDeleted, 1:Deleted' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Reservation', @level2type=N'COLUMN',@level2name=N'is_deleted'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0:NotOccupied, 1:Occupied' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Room', @level2type=N'COLUMN',@level2name=N'is_occupied'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0:NotDeleted, 1:Deleted' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Room', @level2type=N'COLUMN',@level2name=N'is_deleted'
GO
