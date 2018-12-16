--Tabla T_Paises

--Listar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Listar_Paises]') IS NOT NULL DROP PROCEDURE [dbo].sp_Listar_Paises
GO

Create procedure sp_Listar_Paises
as
Begin
SELECT [IdPais]
      ,[NombrePais] as [Nombre País]
      ,[CodigoISOPais] as [Código ISO]
      ,[CodigoAreaPais] as [Código Área]
      ,[IdEstado]       as [Estado]
  FROM [dbo].[T_Paises]
End
GO

-- Filtrar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Filtar_Paises]') IS NOT NULL DROP PROCEDURE [dbo].sp_Filtar_Paises
GO

Create procedure sp_Filtar_Paises
(
@Filtro varchar(85)
)
as
Begin
SELECT [IdPais]
      ,[NombrePais] as [Nombre País]
      ,[CodigoISOPais] as [Código ISO]
      ,[CodigoAreaPais] as [Código Área]
      ,[IdEstado]       as [Estado]
  FROM [dbo].[T_Paises]
  Where NombrePais like '%'+@Filtro+'%'
End
GO

-- Eliminar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Eliminar_Paises]') IS NOT NULL DROP PROCEDURE [dbo].sp_Eliminar_Paises
GO

Create procedure sp_Eliminar_Paises
(
@IdPais int
)
as
Begin
  Delete
  FROM [dbo].[T_Paises]
  Where IdPais = @IdPais
End
GO

-- Modificar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Modificar_Paises]') IS NOT NULL DROP PROCEDURE [dbo].sp_Modificar_Paises
GO

Create procedure sp_Modificar_Paises
(
@IdPais         int,
@NombrePais     varchar(85),
@CodigoISOPais  char(04),
@CodigoAreaPais char(05),
@IdEstado       char(01)
)
as
Begin
   Update [dbo].[T_Paises]
      Set [NombrePais]     = @NombrePais
         ,[CodigoISOPais]  = @CodigoISOPais
         ,[CodigoAreaPais] = @CodigoAreaPais
         ,[IdEstado]       = @IdEstado
  Where IdPais = @IdPais
End
GO

-- Insertar

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Insertar_Pais]') IS NOT NULL DROP PROCEDURE [dbo].sp_Insertar_Pais
GO

CREATE PROCEDURE sp_Insertar_Pais
(
	@NombrePais varchar(85),
	@CodigoISOPais char(4),
	@CodigoAreaPais char(5),
	@IdEstado char(1)
)
AS 
BEGIN
INSERT INTO [dbo].[T_Paises]
           ([NombrePais],
		    [CodigoISOPais]
           ,[CodigoAreaPais]
           ,[IdEstado])
     VALUES
           (@NombrePais
		    ,@CodigoISOPais
		    ,@CodigoAreaPais 
 	 	    ,@IdEstado)
	SELECT MAX([IdPais])
	FROM [dbo].[T_Paises]
End
GO

