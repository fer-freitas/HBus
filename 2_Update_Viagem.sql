USE [UBus]
GO

UPDATE [dbo].[Viagens]
   SET [Status] = 'Finalizado'
 WHERE [Status] <> 'Finalizado' AND DataConclusao <= GETDATE() 
GO
