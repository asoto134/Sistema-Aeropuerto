--Listar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Listar_Tipo_Empleado]') IS NOT NULL DROP PROCEDURE [dbo].sp_Listar_Tipo_Empleado
GO

create procedure sp_Listar_Tipo_Empleado
As
Begin


SELECT [IdTipoEmpleado],
		[DescTipo],
		[IdEstado]

  FROM [dbo].[T_TiposEmpleados]
  End
GO

--Filtrar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Filtrar_Tipo_Empleado]') IS NOT NULL DROP PROCEDURE [dbo].sp_Filtrar_Tipo_Empleado
GO

create procedure sp_Filtrar_Tipo_Empleado
(
	@Filtro varchar(150)
)
As
Begin
SELECT [IdTipoEmpleado],[DescTipo],[IdEstado]
  FROM [dbo].[T_TiposEmpleados]
  Where DescTipo like '%'+@Filtro+'%'
  End
GO

-- Insertar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Insertar_Tipo_Empleado]') IS NOT NULL DROP PROCEDURE [dbo].sp_Insertar_Tipo_Empleado
GO

Create Procedure sp_Insertar_Tipo_Empleado
(
	@DescTipo varchar(150), 
	@IdEstado char(1)
)
As
Begin
INSERT INTO [dbo].[T_TiposEmpleados]
           (DescTipo, IdEstado)
     VALUES
           (@DescTipo, @IdEstado)

		   Select Max(IdTipoEmpleado)
		   From T_TiposEmpleados
		    
		   End

GO

-- Modificar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Modificar_Tipo_Empleado]') IS NOT NULL DROP PROCEDURE [dbo].sp_Modificar_Tipo_Empleado
GO

Create Procedure sp_Modificar_Tipo_Empleado
(
	@IdTipoEmpleado int, @DescTipo varchar(150), @IdEstado char(1)
)
As
Begin

UPDATE [dbo].[T_TiposEmpleados]

   SET 
		DescTipo = @DescTipo,
		IdEstado = @IdEstado

 WHERE IdTipoEmpleado = @IdTipoEmpleado
 End
GO

--Eliminar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Eliminar_Tipo_Empleado]') IS NOT NULL DROP PROCEDURE [dbo].sp_Eliminar_Tipo_Empleado
GO

Create Procedure sp_Eliminar_Tipo_Empleado
(
	@IdTipoEmpleado int
)
As
Begin
DELETE FROM [dbo].[T_TiposEmpleados]

      WHERE IdTipoEmpleado = @IdTipoEmpleado
	  End
GO