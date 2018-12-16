USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_ListarTiposAviones]') IS NOT NULL DROP PROCEDURE [dbo].sp_ListarTiposAviones
GO

Create procedure sp_ListarTiposAviones
as
Begin
SELECT [IdTipoAvion]
      ,[NombreTipoAvion]
      ,[DescTipoAvion]
      ,[CapacidadPasajeros]
      ,[CapacidadPeso]
      ,[IdEstado]
  FROM [dbo].[T_TiposAviones]
End
GO



-- Filtar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_FiltrarTiposAviones]') IS NOT NULL DROP PROCEDURE [dbo].[sp_FiltrarTiposAviones]
GO

Create procedure [dbo].[sp_FiltrarTiposAviones]
(
 @IdTipoAvion varchar(07)
)
as
begin
SELECT [IdTipoAvion]
      ,[NombreTipoAvion]
      ,[DescTipoAvion] 
      ,[CapacidadPasajeros]
      ,[CapacidadPeso]
      ,[IdEstado]
  FROM [dbo].[T_TiposAviones]
  Where IdTipoAvion = @IdTipoAvion
End
GO
-- Modificar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_ModificarTiposAviones]') IS NOT NULL DROP PROCEDURE [dbo].sp_ModificarTiposAviones
GO

Create procedure sp_ModificarTiposAviones
(
 @IdTipoAvion        varchar(07),
 @NombreTipoAvion    varchar(90),
 @DescTipoAvion      varchar(90),
 @CapacidadPasajeros int,
 @CapacidadPeso      decimal(18,2),
 @IdEstado           char(01)
)
as
begin
  Update [dbo].[T_TiposAviones]
     Set NombreTipoAvion    = @NombreTipoAvion,
	     DescTipoAvion      = @DescTipoAvion,
		 CapacidadPasajeros = @CapacidadPasajeros,
		 CapacidadPeso      = @CapacidadPeso,
		 IdEstado           = @IdEstado
  Where IdTipoAvion = @IdTipoAvion
End
GO

-- Eliminar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_EliminarTiposAviones]') IS NOT NULL DROP PROCEDURE [dbo].[sp_EliminarTiposAviones]
GO

Create procedure [dbo].[sp_EliminarTiposAviones]
(
 @IdTipoAvion varchar(07)
)
as
begin
  Delete
  FROM [dbo].[T_TiposAviones]
  Where IdTipoAvion = @IdTipoAvion
End
GO

-- Insertar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Insertar_TiposAviones]') IS NOT NULL DROP PROCEDURE [dbo].sp_Insertar_TiposAviones
GO

CREATE procedure [dbo].[sp_Insertar_TiposAviones]
(
  
  @IdTipoAvion varchar(7),
  @NombreTipoAvion    varchar(90),
  @DescTipoAvion      varchar(90),
  @CapacidadPasajeros         int,
  @CapacidadPeso      decimal(18,2),
  @IdEstado              char(01)
)
as
Begin
  INSERT INTO [dbo].[T_TiposAviones]
    (IdTipoAvion
	 ,NombreTipoAvion
     ,DescTipoAvion
     ,CapacidadPasajeros
     ,CapacidadPeso
     ,IdEstado)
  VALUES
   (@IdTipoAvion
	,@NombreTipoAvion
    ,@DescTipoAvion
    ,@CapacidadPasajeros
    ,@CapacidadPeso
    ,@IdEstado
   )

End