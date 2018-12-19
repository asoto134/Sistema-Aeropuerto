USE [DB_AEROPUERTO_PROGRA_III]
GO

--ELIMINAR

CREATE procedure [dbo].[sp_Eliminar_Cliente]
(
	@IdCliente varchar(7)
)
as begin

DELETE FROM [dbo].[T_Clientes]
      WHERE IdCliente = @IdCliente
	  end
	  GO

--FILTRAR

CREATE PROCEDURE [dbo].[sp_Filtrar_Cliente]
(
	@Filtro VARCHAR(7)
)
AS 
BEGIN
SELECT [IdCliente]
      ,[Cedula]
      ,[Nombre]
      ,[Apellidos]
      ,[Telefono]
      ,[IdTipoCliente]
      ,[IdEstado]
  FROM [dbo].[T_Clientes]
  WHERE [Nombre] like '%' +  @Filtro + '%'
  END
  GO
  
--INSERTAR

CREATE PROCEDURE [dbo].[sp_Insertar_CLiente]
(
    @IdCliente varchar(7),
	@Cedula varchar(11),
	@NombreCliente varchar(25),
	@ApellidoCliente varchar(150),
	@Telefono varchar(9),
	@IdTipoCliente int,
	@IdEstado char(1)
)
as 
begin
INSERT INTO [dbo].[T_Clientes]
           ([IdCliente]
           ,[Cedula]
           ,[Nombre]
           ,[Apellidos]
           ,[Telefono]
           ,[IdTipoCliente]
           ,[IdEstado])
     VALUES
           (@IdCliente, 
           @Cedula, 
           @NombreCliente, 
           @ApellidoCliente, 
           @Telefono, 
           @IdTipoCliente, 
		   @IdEstado)
		   end
GO

--LISTAR

CREATE PROCEDURE [dbo].[sp_Listar_CLiente]
AS
BEGIN
	SELECT [IdCliente]
		  ,[Cedula]
		  ,[Nombre]
		  ,[Apellidos]
		  ,[Telefono]
		  ,[IdTipoCliente]
		  ,[IdEstado]
	  FROM [dbo].[T_Clientes]
END
GO

--MODIFICAR

CREATE procedure [dbo].[sp_Modificar_Cliente]
(
	@IdCliente varchar(7),
	@Cedula varchar(11),
	@NombreCliente varchar(25),
	@ApellidoCliente varchar(150),
	@Telefono varchar(9),
	@IdTipoCliente int,
	@IdEstado char(1)
)
as begin

UPDATE [dbo].[T_Clientes]
   SET 
      [Cedula] = @Cedula,
      [Nombre] = @NombreCliente,
      [Apellidos] = @ApellidoCliente,
      [Telefono] =@Telefono,
      [IdTipoCliente] = @IdTipoCliente,
      [IdEstado] = @IdEstado
 WHERE [IdCliente] = @IdCliente
 end
GO