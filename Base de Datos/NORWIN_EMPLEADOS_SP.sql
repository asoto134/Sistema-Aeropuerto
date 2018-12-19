USE [DB_AEROPUERTO_PROGRA_III]
GO

--ELIMINAR

CREATE PROCEDURE [dbo].[sp_Eliminar_Empleados]
(
	@IdEmpleado VARCHAR(7)
)
AS BEGIN
DELETE FROM [dbo].[T_Empleados]
      WHERE [IdEmpleado] = @IdEmpleado
	  END
	  GO

--FILTRAR

CREATE PROCEDURE [dbo].[sp_Filtrar_Empleados]
(
	@Filtro VARCHAR(25)
)
AS
BEGIN
SELECT [IdEmpleado]
      ,[Cedula]
      ,[Nombre]
      ,[Apellidos]
      ,[Direccion]
      ,[Edad]
      ,[Telefono_Casa]
      ,[Telefono_Referencia]
      ,[Celular]
      ,[Salario]
      ,[IdTipoEmpleado]
      ,[IdAerolinea]
      ,[IdEstado]
  FROM [dbo].[T_Empleados]
  WHERE [Nombre] LIKE '%' + @Filtro + '%'
  END
  GO

--INSERTAR

CREATE PROCEDURE [dbo].[sp_Insertar_Empleados]
(
	@IdEmpleado varchar(7),
	@Cedula varchar(11),
	@Nombre VARCHAR(25),
	@Apellidos VARCHAR(150),
	@Direccion VARCHAR(150),
	@Edad INT,
	@Tel_Casa VARCHAR(9),
	@Tel_Referencia VARCHAR(9),
	@Celular VARCHAR(9),
	@Salario DECIMAL(18,2),
	@IdTipoEmpleado INT,
	@IdAerolinea INT,
	@IdEstado CHAR(1)
)
AS BEGIN
INSERT INTO [dbo].[T_Empleados]
           ([IdEmpleado]
           ,[Cedula]
           ,[Nombre]
           ,[Apellidos]
           ,[Direccion]
           ,[Edad]
           ,[Telefono_Casa]
           ,[Telefono_Referencia]
           ,[Celular]
           ,[Salario]
           ,[IdTipoEmpleado]
           ,[IdAerolinea]
           ,[IdEstado])
     VALUES
           (@IdEmpleado,
		   @Cedula,
		   @Nombre,
		   @Apellidos,
		   @Direccion,
		   @Edad,
		   @Tel_Casa,
		   @Tel_Referencia,
		   @Celular,
		   @Salario,
		   @IdTipoEmpleado,
		   @IdAerolinea,
		   @IdEstado)
		   END
GO

--LISTAR

CREATE PROCEDURE [dbo].[sp_Listar_Empleados]
AS
BEGIN
SELECT [IdEmpleado]
      ,[Cedula]
      ,[Nombre]
      ,[Apellidos]
      ,[Direccion]
      ,[Edad]
      ,[Telefono_Casa]
      ,[Telefono_Referencia]
      ,[Celular]
      ,[Salario]
      ,[IdTipoEmpleado]
      ,[IdAerolinea]
      ,[IdEstado]
  FROM [dbo].[T_Empleados]
  END
  GO

--MODIFICAR

CREATE PROCEDURE [dbo].[sp_Modificar_Empleados]
(
	@IdEmpleado varchar(7),
	@Cedula varchar(11),
	@Nombre VARCHAR(25),
	@Apellidos VARCHAR(150),
	@Direccion VARCHAR(150),
	@Edad INT,
	@Tel_Casa VARCHAR(9),
	@Tel_Referencia VARCHAR(9),
	@Celular VARCHAR(9),
	@Salario DECIMAL(18,2),
	@IdTipoEmpleado INT,
	@IdAerolinea INT,
	@IdEstado CHAR(1)
)
AS BEGIN
UPDATE [dbo].[T_Empleados]
   SET  
       [Cedula] = @Cedula
      ,[Nombre] = @Nombre
      ,[Apellidos] = @Apellidos
      ,[Direccion] = @Direccion
      ,[Edad] = @Edad
      ,[Telefono_Casa] = @Tel_Casa
      ,[Telefono_Referencia] = @Tel_Referencia
      ,[Celular] = @Celular
      ,[Salario] = @Salario 
      ,[IdTipoEmpleado] = @IdTipoEmpleado
      ,[IdAerolinea] = @IdAerolinea
      ,[IdEstado] = @IdEstado
 WHERE [IdEmpleado] = @IdEmpleado
 END
 GO