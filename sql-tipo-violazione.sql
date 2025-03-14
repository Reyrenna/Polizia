USE [poliziaaaaa]
GO

/****** Object:  Table [dbo].[TipoViolazione]    Script Date: 14/03/2025 18:23:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TipoViolazione](
	[IdViolazione] [int] IDENTITY(1,1) NOT NULL,
	[Descrizione] [varchar](2000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdViolazione] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

