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


--Modificar Usuarios

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Modificar_Usuarios]') IS NOT NULL DROP PROCEDURE [dbo].[sp_Modificar_Usuarios]
GO

Create Procedure [dbo].[sp_Modificar_Usuarios]

(
	@Username varchar(15),
	@Password varchar(8),
    @IdEstado char(1)
)
As
Begin

UPDATE 
  [dbo].[T_Usuarios] 
SET 
  [Password] = @Password,
  [IdEstado] = @IdEstado
WHERE
  [Username] = @Username;

End
GO

--Insertar Usuarios

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Insertar_Usuarios]') IS NOT NULL DROP PROCEDURE [dbo].[sp_Insertar_Usuarios]
GO

Create Procedure [dbo].[sp_Insertar_Usuarios]

(
	@Username varchar(15),
	@Password varchar(8),
    @IdEmpleado varchar(7),
    @IdEstado char(1)
)
As
Begin

INSERT INTO 
  [dbo].[T_Usuarios] ([Username],[Password],[IdEmpleado],[IdEstado]) 
VALUES
  (@Username, @Password, @IdEmpleado, @IdEstado)

End
GO

--Validar Usuarios

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Validar_Usuarios]') IS NOT NULL DROP PROCEDURE [dbo].[sp_Validar_Usuarios]
GO

Create Procedure [dbo].[sp_Validar_Usuarios]

(
	@Username varchar(15),
	@Password varchar(8)
)
As
Begin

SELECT 
  1
FROM
  [dbo].[T_Usuarios] 
WHERE
  ([Username] = @Username)
  AND ([Password] = @Password);
  
End
GO

--Cambiar Contraseña 

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Cambiar_Contrasenia]') IS NOT NULL DROP PROCEDURE [dbo].[sp_Cambiar_Contrasenia]
GO

Create Procedure [dbo].[sp_Cambiar_Contrasenia]

(
	@Username varchar(15),
	@Password varchar(8)
)
As
Begin

UPDATE 
  [dbo].[T_Usuarios] 
SET
  [Password] = @Password
WHERE
  ([Username] = @Username);  
  
End
GO

--ListaR Vuelos

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Listar_Vuelos]') IS NOT NULL DROP PROCEDURE [dbo].[sp_Listar_Vuelos]
GO

Create Procedure [dbo].[sp_Listar_Vuelos]
As
Begin

SELECT
  [IdVuelo]
  ,[IdDestino]
  ,[IdAerolinea]
  ,[IdAvion]
  ,[FechaHoraSalida]
  ,[FechaHoraLlegada]
  ,[IdEstado]
FROM 
  [DB_AEROPUERTO_PROGRA_III].[dbo].[T_Vuelos]

End
GO

--Filtrar Usuarios

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Filtrar_Vuelos]') IS NOT NULL DROP PROCEDURE [dbo].[sp_Filtrar_Vuelos]
GO

Create Procedure [dbo].[sp_Filtrar_Vuelos]

(
	@Filtro varchar(5)
)
As
Begin

SELECT
  [IdVuelo]
  ,[IdDestino]
  ,[IdAerolinea]
  ,[IdAvion]
  ,[FechaHoraSalida]
  ,[FechaHoraLlegada]
  ,[IdEstado]
FROM 
  [DB_AEROPUERTO_PROGRA_III].[dbo].[T_Vuelos]
WHERE 
  ([IdVuelo] like '%'+@Filtro+'%');

End
GO

--Eliminar Usuarios

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Eliminar_Vuelos]') IS NOT NULL DROP PROCEDURE [dbo].[sp_Eliminar_Vuelos]
GO

Create Procedure [dbo].[sp_Eliminar_Vuelos]

(
	@IdVuelo varchar(5)
)
As
Begin

DELETE FROM [DB_AEROPUERTO_PROGRA_III].[dbo].[T_Vuelos] WHERE ([IdVuelo] = @IdVuelo);

End
GO

--Modificar Vuelos

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Modificar_Vuelos]') IS NOT NULL DROP PROCEDURE [dbo].[sp_Modificar_Vuelos]
GO

Create Procedure [dbo].[sp_Modificar_Vuelos]

(
	@IdVuelo varchar(5),
	@IdDestino varchar(5),
	@IdAerolinea int,
	@IdAvion varchar(7),
	@FechaHoraSalida datetime,
	@FechaHoraLlegada datetime,
    @IdEstado char(1)
)
As
Begin

UPDATE [dbo].[T_Vuelos]
   SET [IdDestino] = @IdDestino
      ,[IdAerolinea] = @IdAerolinea
      ,[IdAvion] = @IdAvion
      ,[FechaHoraSalida] = @FechaHoraSalida
      ,[FechaHoraLlegada] = @FechaHoraLlegada
      ,[IdEstado] = @IdEstado
 WHERE 
  [IdVuelo] = @IdVuelo;

End
GO

--Insertar Vuelos

USE [DB_AEROPUERTO_PROGRA_III]
GO

IF OBJECT_ID('[dbo].[sp_Insertar_Vuelos]') IS NOT NULL DROP PROCEDURE [dbo].[sp_Insertar_Vuelos]
GO

Create Procedure [dbo].[sp_Insertar_Vuelos]

(
	@IdVuelo varchar(5),
	@IdDestino varchar(5),
	@IdAerolinea int,
	@IdAvion varchar(7),
	@FechaHoraSalida datetime,
	@FechaHoraLlegada datetime,
    @IdEstado char(1)
)
As
Begin

INSERT INTO
  [dbo].[T_Vuelos]([IdVuelo],[IdDestino],[IdAerolinea],[IdAvion],
                   [FechaHoraSalida],[FechaHoraLlegada],[IdEstado])
VALUES (@IdVuelo, @IdDestino, @IdAerolinea, @IdAvion, @FechaHoraSalida,
        @FechaHoraLlegada, @IdEstado);

End
GO

