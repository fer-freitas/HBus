USE [UBus]
GO

INSERT [dbo].[Rotas] 
			([Id], 
			[Origem], 
			[Destino], 
			[Inicio], 
			[Fim], 
			[Valor]) 
		VALUES (N'868e162a-af4e-4080-b4c9-cc9e7fea15db'
				, N'SBC'
				, N'DIA'
				, CAST(N'2018-12-21 05:00:00.000' AS DateTime)
				, CAST(N'2018-12-21 12:00:00.000' AS DateTime)
				, CAST(35.00 AS Numeric(5, 2)))
GO

INSERT INTO [dbo].[Veiculos]
           ([Id]
           ,[Marca]
           ,[Modelo])
     VALUES
           ('AA0AEFF5-A4F8-4900-B3B9-C5F79A402A51'
           ,'Mercedez'
           ,'M1213')

INSERT INTO [dbo].[ItemAdicional]
           ([Id]
           ,[Nome]
           ,[VeiculoId])
     VALUES
		('1A0AE5F5-A4F8-4900-B3B9-C5F79A402A51',
		 'Ar-condicionado',
		 'AA0AEFF5-A4F8-4900-B3B9-C5F79A402A51'
		),
		('F1BAE5F5-A4F8-4900-B3B9-C5F79A402A51',
		 'Banheiro',
		 'AA0AEFF5-A4F8-4900-B3B9-C5F79A402A51'
		),
		('CA0AE598-A4F8-4900-B3B9-C5F79A402A51',
		 'wi-fi',
		 'AA0AEFF5-A4F8-4900-B3B9-C5F79A402A51'
		)

INSERT INTO [dbo].[Viagens]
           ([Id]
           ,[Latitude]
           ,[Longitude]
           ,[Hora]
           ,[RotaId]
           ,[VeiculoId]
           ,[FuncionarioId])
     VALUES
           ('A5283804-8597-4CAA-AFE6-E0E445A6AEE1'
           ,'-23.703265'
           ,'-46.5537544'
           ,'05:00'
           ,N'868e162a-af4e-4080-b4c9-cc9e7fea15db'
           ,N'AA0AEFF5-A4F8-4900-B3B9-C5F79A402A51'
           ,N'00000000-0000-0000-0000-000000000000')

GO


