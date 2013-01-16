USE [master]
GO

CREATE DATABASE [Firma]
GO
USE [Firma]

GO
CREATE TABLE [dbo].[Radnik](
[Id]	[int] IDENTITY (1,1) NOT NULL PRIMARY KEY,
[Ime]	[nvarchar] (50) NOT NULL,
[Prezime]	[nvarchar] (50) NOT NULL,
[datumZaposlenja]	[smalldatetime]	NOT NULL
)
INSERT INTO Radnik VALUES ('Ivan','Krstić','1999-10-12 08:32:00')  