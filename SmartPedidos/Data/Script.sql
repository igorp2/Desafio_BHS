CREATE TABLE [dbo].[ITENS](
	[CODIGO] [int] NOT NULL,
	[CODIGOPEDIDO] [int] NOT NULL,
	[DESCRICAO] [varchar](50) NOT NULL,
	[VALORITEM] [numeric](13, 2) NOT NULL,
 CONSTRAINT [PK_ITENS] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PEDIDOS](
	[CODIGO] [int] NOT NULL,
	[DESCRICAO] [varchar](40) NOT NULL,
	[DATAPEDIDO] [datetime] NOT NULL,
	[VALORPEDIDO] [numeric](13, 2) NOT NULL,
	[STATUS] [char](1) NOT NULL,
 CONSTRAINT [PK_PEDIDOS] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ITENS]  WITH CHECK ADD  CONSTRAINT [FK_ITENS_PEDIDOS] FOREIGN KEY([CODIGOPEDIDO])
REFERENCES [dbo].[PEDIDOS] ([CODIGO])
GO
ALTER TABLE [dbo].[ITENS] CHECK CONSTRAINT [FK_ITENS_PEDIDOS]
GO