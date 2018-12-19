--Listar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Listar_Estados]') IS NOT NULL DROP PROCEDURE [dbo].sp_Listar_Estados
GO

Create Procedure sp_Listar_Estados
As
Begin

SELECT [IdEstado]
      ,[Descripcion]
  FROM [dbo].[T_Estados]
  End
GO

--Filtrar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Filtrar_Estados]') IS NOT NULL DROP PROCEDURE [dbo].sp_Filtrar_Estados
GO

Create Procedure sp_Filtrar_Estados

(
	@IdFiltro varchar(25)
)
As
Begin

DELETE FROM [dbo].[T_Estados]
      WHERE Descripcion = @IdFiltro
	  End

GO

--Insertar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Insertar_Estados]') IS NOT NULL DROP PROCEDURE [dbo].sp_Insertar_Estados
GO

Create Procedure sp_Insertar_Estados
(
	@IdEstado char(1),
    @Descripcion varchar(25)
)

as
begin

INSERT INTO [dbo].[T_Estados]
           ([IdEstado],[Descripcion])
     VALUES
           (@IdEstado, @Descripcion)
  End
GO


--Modificar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Modificar_Estados]') IS NOT NULL DROP PROCEDURE [dbo].sp_Modificar_Estados
GO

Create Procedure sp_Modificar_Estados
(
	@IdEstado char(1),
    @Descripcion varchar(25)
)

As
Begin
	UPDATE [dbo].[T_Estados]
	SET 
		[Descripcion] = @Descripcion


	WHERE [IdEstado] = @IdEstado 
  End
GO



--Eliminar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Eliminar_Estados]') IS NOT NULL DROP PROCEDURE [dbo].sp_Eliminar_Estados
GO

Create Procedure sp_Eliminar_Estados

(
	@IdEstado char(1)
)
As
Begin

DELETE FROM [dbo].[T_Estados]
      WHERE IdEstado = @IdEstado
	  End

GO