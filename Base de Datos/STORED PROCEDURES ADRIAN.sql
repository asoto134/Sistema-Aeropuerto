--ListaR Usuarios

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Listar_Usuarios]') IS NOT NULL DROP PROCEDURE [dbo].[sp_Listar_Usuarios]
GO

Create Procedure [dbo].[sp_Listar_Usuarios]
As
Begin

SELECT
  [Username]
  ,[Password]
  ,[IdEmpleado]
  ,[IdEstado]
FROM 
  [DB_AEROPUERTO_PROGRA_III].[dbo].[T_Usuarios]
End
GO

--Filtrar Usuarios

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Filtrar_Usuarios]') IS NOT NULL DROP PROCEDURE [dbo].[sp_Filtrar_Usuarios]
GO

Create Procedure [dbo].[sp_Filtrar_Usuarios]

(
	@Filtro varchar(15)
)
As
Begin

SELECT
  [Username]
  ,[Password]
  ,[IdEmpleado]
  ,[IdEstado]
FROM 
  [DB_AEROPUERTO_PROGRA_III].[dbo].[T_Usuarios]
WHERE 
  ([Username] like '%'+@Filtro+'%')
  OR ([IdEmpleado] like '%'+@Filtro+'%');

End
GO


--Eliminar Usuarios

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Eliminar_Usuarios]') IS NOT NULL DROP PROCEDURE [dbo].[sp_Eliminar_Usuarios]
GO

Create Procedure [dbo].[sp_Eliminar_Usuarios]

(
	@Username varchar(15)
)
As
Begin

DELETE FROM [DB_AEROPUERTO_PROGRA_III].[dbo].[T_Usuarios] WHERE ([Username] = @Username);

End
GO
