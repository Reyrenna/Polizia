USE [poliziaaaaa]
GO

/****** Object:  Table [dbo].[Verbale]    Script Date: 14/03/2025 18:24:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Verbale](
	[IdVerbale] [int] IDENTITY(1,1) NOT NULL,
	[DataViolazione] [datetime] NOT NULL,
	[IndirizzoViolazione] [varchar](80) NOT NULL,
	[Nominativo_Agente] [varchar](50) NOT NULL,
	[DataTrascrizioneVerbale] [datetime] NOT NULL,
	[Importo] [decimal](10, 2) NOT NULL,
	[DecurtamentoPunti] [int] NOT NULL,
	[IdAnagrafica] [int] NOT NULL,
	[IdViolazione] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdVerbale] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Verbale]  WITH CHECK ADD  CONSTRAINT [FK_IdInfrazione] FOREIGN KEY([IdViolazione])
REFERENCES [dbo].[TipoViolazione] ([IdViolazione])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Verbale] CHECK CONSTRAINT [FK_IdInfrazione]
GO

ALTER TABLE [dbo].[Verbale]  WITH CHECK ADD  CONSTRAINT [FK_IdPersona] FOREIGN KEY([IdAnagrafica])
REFERENCES [dbo].[Anagrafica] ([IdAnagrafica])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Verbale] CHECK CONSTRAINT [FK_IdPersona]
GO

