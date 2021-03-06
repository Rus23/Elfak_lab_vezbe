USE [OOP]
GO
/****** Object:  Table [dbo].[ispit]    Script Date: 20/11/2016 14:36:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ispit](
	[ispit_id] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [varchar](150) NOT NULL,
	[sifra] [varchar](10) NOT NULL,
 CONSTRAINT [PK_ispit] PRIMARY KEY CLUSTERED 
(
	[ispit_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[student]    Script Date: 20/11/2016 14:36:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[student](
	[student_id] [bigint] IDENTITY(1,1) NOT NULL,
	[ime] [varchar](50) NOT NULL,
	[prezime] [varchar](50) NOT NULL,
	[index] [int] NOT NULL,
 CONSTRAINT [PK_student] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[student_ispit]    Script Date: 20/11/2016 14:36:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_ispit](
	[student_ispit_id] [bigint] IDENTITY(1,1) NOT NULL,
	[student_id] [bigint] NOT NULL,
	[ispit_id] [int] NOT NULL,
 CONSTRAINT [PK_student_ispit] PRIMARY KEY CLUSTERED 
(
	[student_ispit_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[student_telefon]    Script Date: 20/11/2016 14:36:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[student_telefon](
	[student_telefon_id] [bigint] IDENTITY(1,1) NOT NULL,
	[student_id] [bigint] NOT NULL,
	[telefon] [varchar](30) NOT NULL,
 CONSTRAINT [PK_student_telefon] PRIMARY KEY CLUSTERED 
(
	[student_telefon_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[student_ispit]  WITH CHECK ADD  CONSTRAINT [FK_student_ispit_ispit] FOREIGN KEY([ispit_id])
REFERENCES [dbo].[ispit] ([ispit_id])
GO
ALTER TABLE [dbo].[student_ispit] CHECK CONSTRAINT [FK_student_ispit_ispit]
GO
ALTER TABLE [dbo].[student_ispit]  WITH CHECK ADD  CONSTRAINT [FK_student_ispit_student] FOREIGN KEY([student_id])
REFERENCES [dbo].[student] ([student_id])
GO
ALTER TABLE [dbo].[student_ispit] CHECK CONSTRAINT [FK_student_ispit_student]
GO
ALTER TABLE [dbo].[student_telefon]  WITH CHECK ADD  CONSTRAINT [FK_student_telefon_student] FOREIGN KEY([student_id])
REFERENCES [dbo].[student] ([student_id])
GO
ALTER TABLE [dbo].[student_telefon] CHECK CONSTRAINT [FK_student_telefon_student]
GO
