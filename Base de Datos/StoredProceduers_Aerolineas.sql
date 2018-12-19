--Listar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Listar_Aerolineas]') IS NOT NULL DROP PROCEDURE [dbo].sp_Listar_Aerolineas
GO

Create Procedure sp_Listar_Aerolineas
As
Begin

SELECT [IdAerolinea]
      ,[NombreAerolinea]
      ,[IdEstado]

  FROM [dbo].[T_Aerolineas]
  End
GO

--Filtrar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Filtrar_Aerolineas]') IS NOT NULL DROP PROCEDURE [dbo].sp_Filtrar_Aerolineas
GO

create Procedure sp_Filtrar_Aerolineas

(
	@Filtro varchar(90)
)
As
Begin

SELECT [IdAerolinea]
      ,[NombreAerolinea]
      ,[IdEstado]
  FROM [dbo].[T_Aerolineas]
  where [NombreAerolinea] like '%'+ @Filtro + '%'
  end
GO


--Insertar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Insertar_Aerolineas]') IS NOT NULL DROP PROCEDURE [dbo].[sp_Insertar_Aerolineas]
GO

Create Procedure [dbo].[sp_Insertar_Aerolineas]
(	
    @NombreAerolinea varchar(90),
	@IdEstado CHAR(1)
)

as
begin

	INSERT INTO [dbo].[T_Aerolineas]
           ([NombreAerolinea], [IdEstado])
     VALUES
           (@NombreAerolinea, @IdEstado)

	SELECT MAX([IdAerolinea])
	FROM [dbo].[T_Aerolineas]

  End
GO
--Modificar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Modificar_Aerolineas]') IS NOT NULL DROP PROCEDURE [dbo].sp_Modificar_Aerolineas
GO

Create Procedure sp_Modificar_Aerolineas
(
	@IdAerolinea int,
    @NombreAerolinea varchar(90),
	@IdEstado char(1)
)

As
Begin
	UPDATE [dbo].[T_Aerolineas]
	SET 
		[NombreAerolinea] = @NombreAerolinea,
		[IdEstado] = @IdEstado


	WHERE [IdAerolinea] = @IdAerolinea 
  End
GO

--Eliminar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Eliminar_Aerolineas]') IS NOT NULL DROP PROCEDURE [dbo].sp_Eliminar_Aerolineas
GO

Create Procedure sp_Eliminar_Aerolineas

(
	@ELIMINAR int
)
As
Begin

DELETE FROM [dbo].[T_Aerolineas]
      WHERE IdAerolinea = @ELIMINAR
	  End

GO
