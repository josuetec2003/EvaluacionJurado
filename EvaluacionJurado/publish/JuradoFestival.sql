USE [JuradoFestival]
GO
/****** Object:  Table [dbo].[Jueces]    Script Date: 08/19/2012 14:14:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jueces](
	[IDJuez] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](15) NULL,
	[Contrasena] [nvarchar](40) NULL,
	[Nombre] [nvarchar](20) NULL,
	[Apellido] [nvarchar](20) NULL,
	[AnioParticipacion] [int] NULL,
 CONSTRAINT [PK_Jueces] PRIMARY KEY CLUSTERED 
(
	[IDJuez] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Instituto]    Script Date: 08/19/2012 14:14:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Instituto](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[Direccion] [nvarchar](max) NULL,
	[Tel] [char](10) NULL,
	[NombreContacto] [nvarchar](25) NULL,
 CONSTRAINT [PK__Institut__3214EC2607020F21] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 100) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Festival]    Script Date: 08/19/2012 14:14:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Festival](
	[IDFestival] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Homenajeado] [nvarchar](50) NULL,
	[Año] [int] NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Festival] PRIMARY KEY CLUSTERED 
(
	[IDFestival] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cancion]    Script Date: 08/19/2012 14:14:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cancion](
	[IDCancion] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[Interprete] [nvarchar](50) NULL,
	[Genero] [nvarchar](50) NULL,
 CONSTRAINT [PK__Cancion__812F2B8A0EA330E9] PRIMARY KEY NONCLUSTERED 
(
	[IDCancion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 100) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Administradores]    Script Date: 08/19/2012 14:14:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administradores](
	[IDUser] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Username] [nvarchar](25) NULL,
	[Password] [nvarchar](40) NULL,
 CONSTRAINT [PK_Administradores] PRIMARY KEY CLUSTERED 
(
	[IDUser] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participante]    Script Date: 08/19/2012 14:14:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participante](
	[IDParticipante] [int] IDENTITY(1,1) NOT NULL,
	[OrdenParticipacion] [int] NULL,
	[Nombre] [nvarchar](30) NULL,
	[Apellido] [nvarchar](30) NULL,
	[IDFestival] [int] NULL,
	[IdInstituto] [int] NULL,
	[IdCancion] [int] NULL,
 CONSTRAINT [PK__Particip__A316065D1273C1CD] PRIMARY KEY NONCLUSTERED 
(
	[IDParticipante] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 100) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evaluacion]    Script Date: 08/19/2012 14:14:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluacion](
	[IDParticipante] [int] NOT NULL,
	[IDJuez] [int] NOT NULL,
	[eval1] [int] NULL,
	[eval2] [int] NULL,
	[eval3] [int] NULL,
	[eval4] [int] NULL,
	[eval5] [int] NULL,
	[eval6] [int] NULL,
	[eval7] [int] NULL,
 CONSTRAINT [PK_Evaluacion] PRIMARY KEY CLUSTERED 
(
	[IDJuez] ASC,
	[IDParticipante] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Participante_Cancion]    Script Date: 08/19/2012 14:14:38 ******/
ALTER TABLE [dbo].[Participante]  WITH CHECK ADD  CONSTRAINT [FK_Participante_Cancion] FOREIGN KEY([IdCancion])
REFERENCES [dbo].[Cancion] ([IDCancion])
GO
ALTER TABLE [dbo].[Participante] CHECK CONSTRAINT [FK_Participante_Cancion]
GO
/****** Object:  ForeignKey [FK_Participante_Festival]    Script Date: 08/19/2012 14:14:38 ******/
ALTER TABLE [dbo].[Participante]  WITH CHECK ADD  CONSTRAINT [FK_Participante_Festival] FOREIGN KEY([IDFestival])
REFERENCES [dbo].[Festival] ([IDFestival])
GO
ALTER TABLE [dbo].[Participante] CHECK CONSTRAINT [FK_Participante_Festival]
GO
/****** Object:  ForeignKey [FK_Participante_Instituto]    Script Date: 08/19/2012 14:14:38 ******/
ALTER TABLE [dbo].[Participante]  WITH CHECK ADD  CONSTRAINT [FK_Participante_Instituto] FOREIGN KEY([IdInstituto])
REFERENCES [dbo].[Instituto] ([ID])
GO
ALTER TABLE [dbo].[Participante] CHECK CONSTRAINT [FK_Participante_Instituto]
GO
/****** Object:  ForeignKey [FK_Evaluacion_Jueces]    Script Date: 08/19/2012 14:14:38 ******/
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Jueces] FOREIGN KEY([IDJuez])
REFERENCES [dbo].[Jueces] ([IDJuez])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_Jueces]
GO
/****** Object:  ForeignKey [FK_Evaluacion_Participante]    Script Date: 08/19/2012 14:14:38 ******/
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Participante] FOREIGN KEY([IDParticipante])
REFERENCES [dbo].[Participante] ([IDParticipante])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_Participante]
GO
