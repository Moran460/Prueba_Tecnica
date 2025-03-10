Create Database Prueba_Tecnica
go
USE Prueba_Tecnica

Create Table Loans(
Id int IDENTITY(1,1) Primary Key,
Cliente NVARCHAR(100) NOT NULL,
Monto DECIMAL(18,2) NOT NULL,
TasaInteres FLOAT NOT NULL,
PlazoMeses INT NOT NULL,
FechaInicio DATETIME DEFAULT GETDATE()
);