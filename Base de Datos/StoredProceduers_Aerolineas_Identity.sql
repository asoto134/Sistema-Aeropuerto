--En caso de Identity

USE [DB_AEROPUERTO_PROGRA_III]
GO
/****** Object:  StoredProcedure [dbo].[sp_Insertar_Aerolineas]    Script Date: 2018/28/nov. 18:57:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('[dbo].[sp_Insertar_Aerolineas]') IS NOT NULL DROP PROCEDURE [dbo].sp_Insertar_Aerolineas
GO

CREATE Procedure [dbo].[sp_Insertar_Aerolineas]
(	
    @NombreAerolinea varchar(90),
	@IdEstado CHAR(1)
)

as
begin

	INSERT INTO [dbo].[T_Aerolineas]
           ([NombreAerolinea], [IdEstado])
     VALUES
           (@NombreAerolinea, @IdEstado)

	SELECT MAX([IdAerolinea])
	FROM [dbo].[T_Aerolineas]

  End