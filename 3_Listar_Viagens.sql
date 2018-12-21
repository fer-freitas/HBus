USE [UBus]
GO

SELECT v.*, f.PrimeiroNome FROM [dbo].[Viagens] v
LEFT JOIN [dbo].[Funcionarios] f on v.FuncionarioId = f.Id