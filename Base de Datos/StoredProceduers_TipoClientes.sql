--Listar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Listar_Tipo_Clientes]') IS NOT NULL DROP PROCEDURE [dbo].sp_Listar_Tipo_Clientes
GO

create procedure sp_Listar_Tipo_Clientes
As
Begin


SELECT [IdTipoCliente]
      ,[TipoCliente]
      ,[Descripcion]
      ,[IdEstado]
  FROM [dbo].[T_TiposClientes]
  End
GO

--Filtrar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Filtrar_Tipo_Clientes]') IS NOT NULL DROP PROCEDURE [dbo].sp_Filtrar_Tipo_Clientes
GO

create procedure sp_Filtrar_Tipo_Clientes
(
	@Filtro varchar(150)
)
As
Begin
SELECT [IdTipoCliente]
      ,[TipoCliente]
      ,[Descripcion]
      ,[IdEstado]
  FROM [dbo].[T_TiposClientes]
  Where Descripcion like '%'+@Filtro+'%'
  End
GO

-- Insertar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Insertar_Tipo_Clientes]') IS NOT NULL DROP PROCEDURE [dbo].sp_Insertar_Tipo_Clientes
GO

Create Procedure sp_Insertar_Tipo_Clientes
(
	@TipoCliente varchar(50), @Descripcion varchar(150), @IdEstado char(1)
)
As
Begin
INSERT INTO [dbo].[T_TiposClientes]
           (TipoCliente, Descripcion, IdEstado)
     VALUES
           (@TipoCliente, @Descripcion, @IdEstado)

		   Select Max(IdTipoCliente)
		   From T_TiposClientes
		    
		   End

GO

-- Modificar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Modificar_Tipo_Clientes]') IS NOT NULL DROP PROCEDURE [dbo].sp_Modificar_Tipo_Clientes
GO

Create Procedure sp_Modificar_Tipo_Clientes
(
	@IdTipoCliente int, @TipoCliente varchar(50), @Descripcion varchar(150), @IdEstado char(1)
)
As
Begin

UPDATE [dbo].[T_TiposClientes]

   SET 
		TipoCliente = @TipoCliente, Descripcion = @Descripcion, IdEstado = @IdEstado

 WHERE IdTipoCliente = @IdTipoCliente
 End
GO

--Eliminar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Eliminar_Tipo_Clientes]') IS NOT NULL DROP PROCEDURE [dbo].sp_Eliminar_Tipo_Clientes
GO

Create Procedure sp_Eliminar_Tipo_Clientes
(
	@IdTipoCliente int
)
As
Begin
DELETE FROM [dbo].[T_TiposClientes]

      WHERE IdTipoCliente = @IdTipoCliente
	  End
GO

