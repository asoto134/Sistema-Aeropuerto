USE [DB_AEROPUERTO_PROGRA_III]
GO

--ELIMINAR

CREATE PROCEDURE [dbo].[sp_Eliminar_Destinos]
(
	@IdDestino VARCHAR(5)
)
AS
BEGIN
DELETE FROM [dbo].[T_Destinos]
      WHERE [IdDestino] = @IdDestino
	  END
GO

--FILTRAR

CREATE PROCEDURE [dbo].[sp_Filtrar_Destinos]
(
	@Filtro VARCHAR(57)
)
AS
BEGIN
SELECT [IdDestino]
      ,[IdAerolinea]
      ,[NomDestino]
      ,[PaisSalida]
      ,[PaisLlegada]
      ,[IdEstado]
  FROM [dbo].[T_Destinos]
  WHERE [NomDestino] LIKE  '%' + @Filtro + '%'
  END
  GO

--INSERTAR

CREATE PROCEDURE [dbo].[sp_Insertar_Destinos]
(
	@IdDestino varchar(5),
	@IdAerolinea int,
	@NomDestino varchar(57),
	@IdPaisSalida int,
	@IdPaisLlegada int,
	@IdEstado  char(1)
)
AS
BEGIN
INSERT INTO [dbo].[T_Destinos]
           ([IdDestino]
           ,[IdAerolinea]
           ,[NomDestino]
           ,[PaisSalida]
           ,[PaisLlegada]
           ,[IdEstado])
     VALUES
           (@IdDestino,@IdAerolinea,@NomDestino,
		   @IdPaisSalida,@IdPaisLlegada,@IdEstado)
		   END
GO

--LISTAR

CREATE PROCEDURE [dbo].[sp_Listar_Destinos]
AS
BEGIN

SELECT [IdDestino]
      ,[IdAerolinea]
      ,[NomDestino]
      ,[PaisSalida]
      ,[PaisLlegada]
      ,[IdEstado]
  FROM [dbo].[T_Destinos]
  END
  GO

--MODIFICAR

CREATE PROCEDURE [dbo].[sp_Modificar_Destinos]
(
	@IdDestino  varchar(5),
	@IdAerolinea int,
	@NomDestino varchar(57),
	@IdPaisSalida int,
	@IdPaisLlegada int,
	@IdEstado char(1)
)
AS
BEGIN
UPDATE [dbo].[T_Destinos]
   SET   
       [IdAerolinea] = @IdAerolinea
      ,[NomDestino] = @NomDestino
      ,[PaisSalida] = @IdPaisSalida
      ,[PaisLlegada] = @IdPaisLlegada
      ,[IdEstado] = @IdEstado
 WHERE [IdDestino] = @IdDestino
 END
GO

