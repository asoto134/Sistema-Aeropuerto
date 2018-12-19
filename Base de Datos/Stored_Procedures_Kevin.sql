USE [DB_AEROPUERTO_PROGRA_III]
GO


/****** Object:  StoredProcedure [dbo].[sp_Eliminar_Aerolineas]    Script Date: 10/12/2018 4:50:10 a. m. ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Eliminar_Aerolineas]') IS NOT NULL DROP PROCEDURE [dbo].[sp_Eliminar_Aerolineas]
GO

CREATE PROCEDURE [dbo].[sp_Eliminar_Aerolineas]
(
@ELIMINAR INT

)
AS
BEGIN

DELETE FROM [dbo].[T_Aerolineas]
      WHERE [IdAerolinea] = @ELIMINAR

END
GO
/****** Object:  StoredProcedure [dbo].[sp_Eliminar_Aviones]    Script Date: 10/12/2018 4:50:10 a. m. ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Eliminar_Aviones]') IS NOT NULL DROP PROCEDURE [dbo].sp_Eliminar_Aviones
GO

CREATE PROCEDURE [dbo].[sp_Eliminar_Aviones]
(
@ELIMINAR VARCHAR (7)
)
AS
BEGIN
DELETE FROM [dbo].[T_Aviones]
      WHERE [IdAvion] = @ELIMINAR
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Eliminar_CategoriaVuelos]    Script Date: 10/12/2018 4:50:10 a. m. ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Eliminar_CategoriaVuelos]') IS NOT NULL DROP PROCEDURE [dbo].sp_Eliminar_CategoriaVuelos
GO

CREATE PROCEDURE [dbo].[sp_Eliminar_CategoriaVuelos]
(
@ELIMINAR INT

)
AS
BEGIN

DELETE FROM [dbo].[T_CategoriasVuelos]
      WHERE [IdCategoria] = @ELIMINAR
 END
GO
/****** Object:  StoredProcedure [dbo].[sp_Filtrar_Aerolineas]    Script Date: 10/12/2018 4:50:10 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Filtrar_Aerolineas]') IS NOT NULL DROP PROCEDURE [dbo].sp_Filtrar_Aerolineas
GO

CREATE PROCEDURE [dbo].[sp_Filtrar_Aerolineas]
(
@FILTRO VARCHAR (90)

)
AS
BEGIN


SELECT [IdAerolinea]
      ,[NombreAerolinea]
      ,[IdEstado]
  FROM [dbo].[T_Aerolineas]
  WHERE [NombreAerolinea] LIKE  '%' + @FILTRO + '%'
  END

GO
/****** Object:  StoredProcedure [dbo].[sp_Filtrar_Aviones]    Script Date: 10/12/2018 4:50:10 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Filtrar_Aviones]') IS NOT NULL DROP PROCEDURE [dbo].sp_Filtrar_Aviones
GO

CREATE PROCEDURE [dbo].[sp_Filtrar_Aviones]
(
@FILTRO VARCHAR (57)
)
AS
BEGIN

SELECT [IdAvion]
      ,[NomAvion]
      ,[DescAvion]
      ,[IdAerolinea]
      ,[IdTipoAvion]
      ,[IdEstado]
  FROM [dbo].[T_Aviones]
  WHERE [NomAvion] LIKE  '%' + @FILTRO + '%'
  END
GO
/****** Object:  StoredProcedure [dbo].[sp_Filtrar_CategoriaVuelos]    Script Date: 10/12/2018 4:50:10 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Filtrar_CategoriaVuelos]') IS NOT NULL DROP PROCEDURE [dbo].sp_Filtrar_CategoriaVuelos
GO

CREATE PROCEDURE [dbo].[sp_Filtrar_CategoriaVuelos]
(
@FILTRO VARCHAR (90)
)
AS
BEGIN
SELECT [IdCategoria]
      ,[DescCategoria]
      ,[IdEstado]
  FROM [dbo].[T_CategoriasVuelos]
  WHERE [DescCategoria] LIKE  '%' + @FILTRO + '%'
  END
GO
/****** Object:  StoredProcedure [dbo].[sp_Insertar_Aerolineas]    Script Date: 10/12/2018 4:50:10 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Insertar_Aerolineas]') IS NOT NULL DROP PROCEDURE [dbo].sp_Insertar_Aerolineas
GO

CREATE PROCEDURE [dbo].[sp_Insertar_Aerolineas]
(
		@NombreAerolinea VARCHAR (90),
        @IdEstado  CHAR (1)

)
AS
BEGIN


INSERT INTO [dbo].[T_Aerolineas]
           ([NombreAerolinea] ,[IdEstado])

     VALUES
           (@NombreAerolinea, @IdEstado )

	SELECT MAX ([IdAerolinea])
	FROM [dbo].[T_Aerolineas]
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Insertar_Aviones]    Script Date: 10/12/2018 4:50:10 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Insertar_Aviones]') IS NOT NULL DROP PROCEDURE [dbo].sp_Insertar_Aviones
GO

CREATE PROCEDURE [dbo].[sp_Insertar_Aviones]
(
			
			@IdAvion varchar(7),
           @NomAvion varchar(57),
		    @DescAvion varchar(120),
			@IdAerolinea int,
           @IdTipoAvion varchar(7),
           @IdEstado char(1)
)

as
BEGIN
INSERT INTO [dbo].[T_Aviones]
           ([IdAvion]
           ,[NomAvion]
           ,[DescAvion]
		   ,[IdAerolinea]
           ,[IdTipoAvion]
           ,[IdEstado])
     VALUES
           (@IdAvion,
           @NomAvion,
		    @DescAvion,
			@IdAerolinea,
           @IdTipoAvion,
           @IdEstado)

	
END

GO
/****** Object:  StoredProcedure [dbo].[sp_Insertar_CategoriaVuelos]    Script Date: 10/12/2018 4:50:10 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Insertar_CategoriaVuelos]') IS NOT NULL DROP PROCEDURE [dbo].sp_Insertar_CategoriaVuelos
GO

CREATE PROCEDURE [dbo].[sp_Insertar_CategoriaVuelos]
(
	  @DescCategoria varchar(90),
       @IdEstado char(1)
)
AS
BEGIN

INSERT INTO [dbo].[T_CategoriasVuelos]
           ([DescCategoria]
           ,[IdEstado])
     VALUES
           (@DescCategoria,
           @IdEstado )
	SELECT MAX ([IdCategoria])
	FROM [dbo].[T_CategoriasVuelos]
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Insertar_Estados]    Script Date: 10/12/2018 4:50:10 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Insertar_Estados]') IS NOT NULL DROP PROCEDURE [dbo].sp_Insertar_Estados
GO

create procedure [dbo].[sp_Insertar_Estados]
(
            @IdEstado char(1),
           @Descripcion varchar(25)
)
as
BEGIN
INSERT INTO [dbo].[T_Estados]
           ([IdEstado]
           ,[Descripcion])
     VALUES
           (@IdEstado, @Descripcion)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Listar_Aerolineas]    Script Date: 10/12/2018 4:50:10 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Listar_Aerolineas]') IS NOT NULL DROP PROCEDURE [dbo].sp_Listar_Aerolineas
GO

CREATE PROCEDURE [dbo].[sp_Listar_Aerolineas]
AS
BEGIN


SELECT [IdAerolinea]
      ,[NombreAerolinea]
      ,[IdEstado]
  FROM [dbo].[T_Aerolineas]
  END

GO
/****** Object:  StoredProcedure [dbo].[sp_Listar_Aviones]    Script Date: 10/12/2018 4:50:10 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Listar_Aviones]') IS NOT NULL DROP PROCEDURE [dbo].sp_Listar_Aviones
GO

CREATE PROCEDURE [dbo].[sp_Listar_Aviones]
AS
BEGIN

SELECT [IdAvion]
      ,[NomAvion]
      ,[DescAvion]
      ,[IdAerolinea]
      ,[IdTipoAvion]
      ,[IdEstado]
  FROM [dbo].[T_Aviones]
  END
GO
/****** Object:  StoredProcedure [dbo].[sp_Listar_CategoriaVuelos]    Script Date: 10/12/2018 4:50:10 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Listar_CategoriaVuelos]') IS NOT NULL DROP PROCEDURE [dbo].sp_Listar_CategoriaVuelos
GO

CREATE PROCEDURE [dbo].[sp_Listar_CategoriaVuelos]

AS

BEGIN

SELECT [IdCategoria]
      ,[DescCategoria]
      ,[IdEstado]
  FROM [dbo].[T_CategoriasVuelos]
  END

GO
/****** Object:  StoredProcedure [dbo].[sp_Listar_Estados]    Script Date: 10/12/2018 4:50:10 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Listar_Estados]') IS NOT NULL DROP PROCEDURE [dbo].sp_Listar_Estados
GO

CREATE PROCEDURE [dbo].[sp_Listar_Estados]
AS
BEGIN

SELECT [IdEstado]
      ,[Descripcion]
  FROM [dbo].[T_Estados]
  END
GO
/****** Object:  StoredProcedure [dbo].[sp_Modificar_Aerolineas]    Script Date: 10/12/2018 4:50:10 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Modificar_Aerolineas]') IS NOT NULL DROP PROCEDURE [dbo].sp_Modificar_Aerolineas
GO

Create Procedure [dbo].[sp_Modificar_Aerolineas]
(
	@IdAerolinea int,
    	@NombreAerolinea varchar(90),
	@IdEstado CHAR(1)
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
/****** Object:  StoredProcedure [dbo].[sp_Modificar_Aviones]    Script Date: 10/12/2018 4:50:10 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Modificar_Aviones]') IS NOT NULL DROP PROCEDURE [dbo].sp_Modificar_Aviones
GO

CREATE PROCEDURE [dbo].[sp_Modificar_Aviones]
(
	  @IdAvion varchar(7),
      @NomAvion  varchar(57),
      @DescAvion varchar(120),
      @IdAerolinea int,
      @IdTipoAvion  varchar(7),
      @IdEstado char(1)
)
AS
BEGIN
UPDATE [dbo].[T_Aviones]
   SET [IdAvion] = @IdAvion,
      [NomAvion] = @NomAvion,
      [DescAvion] = @DescAvion,
      [IdAerolinea] = @IdAerolinea,
      [IdTipoAvion] = @IdTipoAvion,
      [IdEstado] = @IdEstado
 WHERE [IdAerolinea] = @IdAerolinea 
 END
GO
/****** Object:  StoredProcedure [dbo].[sp_Modificar_CategoriasVuelos]    Script Date: 10/12/2018 4:50:10 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Modificar_CategoriasVuelos]') IS NOT NULL DROP PROCEDURE [dbo].sp_Modificar_CategoriasVuelos
GO

CREATE PROCEDURE [dbo].[sp_Modificar_CategoriasVuelos]
(   
	@IdCategoria int,
	@DescCategoria varchar(90),
      @IdEstado char(1)
)
AS
BEGIN


UPDATE [dbo].[T_CategoriasVuelos]
   SET [DescCategoria] = @DescCategoria,
       [IdEstado] = @IdEstado
 WHERE  [IdCategoria]  = @IdCategoria
 END
GO
/****** Object:  StoredProcedure [dbo].[sp_Modificar_Estados]    Script Date: 10/12/2018 4:50:10 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Modificar_Estados]') IS NOT NULL DROP PROCEDURE [dbo].sp_Modificar_Estados
GO

create procedure [dbo].[sp_Modificar_Estados]
(
            @IdEstado char(1),
           @Descripcion varchar(25)
)
as
begin

UPDATE [dbo].[T_Estados]
   SET 
     [Descripcion] = @Descripcion 
 WHERE [IdEstado] = @IdEstado
 end
GO
USE [master]
GO
ALTER DATABASE [DB_AEROPUERTO_PROGRA_III] SET  READ_WRITE 
GO
