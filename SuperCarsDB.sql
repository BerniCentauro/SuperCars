CREATE DATABASE [SuperCars]
GO
USE [SuperCars]
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 29/11/2016 2:29:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehicle](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](100) NOT NULL,
	[Type] [varchar](50) NULL,
	[Brand] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Year] [int] NULL,
	[Color] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Description] [varchar](500) NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Telephone] [int] NOT NULL,
	[Url] [varchar](200) NULL,
 CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
