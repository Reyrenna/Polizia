USE [poliziaaaaa]
GO

/****** Object:  Table [dbo].[Anagrafica]    Script Date: 14/03/2025 18:23:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Anagrafica](
	[IdAnagrafica] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL,
	[Cognome] [varchar](50) NULL,
	[Indirizzo] [varchar](150) NOT NULL,
	[Citta] [varchar](50) NULL,
	[CAP] [varchar](10) NOT NULL,
	[Cod_Fisc] [char](16) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdAnagrafica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

