USE [Forum]
GO

/****** Object:  Table [dbo].[OneUser]    Script Date: 30.05.2019 11:24:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[OneUser](
	[name] [nvarchar](max) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
	[foto] [varbinary](max) NULL,
	[age] [int] NULL,
	[rating] [int] NOT NULL,
	[ratingAnswers] [int] NOT NULL,
	[ratingQwery] [int] NOT NULL,
	[about] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [Forum]
GO

/****** Object:  Table [dbo].[Ansver]    Script Date: 30.05.2019 11:24:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Ansver](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[QweryId] [int] NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[text] [nvarchar](max) NULL,
	[date] [datetime] NOT NULL,
	[rating] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
 CONSTRAINT [PK_Ansver] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

USE [Forum]
GO

/****** Object:  Table [dbo].[Qwery]    Script Date: 30.05.2019 11:24:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Qwery](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[header] [nvarchar](max) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[text] [nvarchar](max) NULL,
	[date] [datetime] NOT NULL,
	[rating] [int] NOT NULL,
	[category] [nvarchar](max) NOT NULL,
	[code] [nvarchar](max) NULL,
 CONSTRAINT [PK_Qwery] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

