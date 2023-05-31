IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Iceberg')
	BEGIN 
		CREATE DATABASE [Iceberg]
	END
GO 
	USE [Iceberg]
GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Cliente')
	BEGIN
		CREATE TABLE Cliente(
			Id INT IDENTITY(1,1) PRIMARY KEY ,
			Nombres VARCHAR(255) NOT NULL,
			Apellidos VARCHAR(255) NOT NULL,
			Domicilio VARCHAR(255) NOT NULL,
			TelefonoFijo VARCHAR(255) NULL,
			Celular VARCHAR(255) NOT NULL,
			CorreoElectronico VARCHAR(255) NOT NULL,
			SaldoDeudor FLOAT NOT NULL,
			Estado BIT NOT NULL
		)
	END